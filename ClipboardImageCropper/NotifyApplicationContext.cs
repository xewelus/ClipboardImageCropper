using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ClipboardImageCropper.Properties;

namespace ClipboardImageCropper
{
	public class NotifyApplicationContext : ApplicationContext
	{
		private readonly NotifyIcon notifyIcon;
		private readonly ToolStripItem miAutosize;
		private Size needSize = new Size(320, 240);

		public NotifyApplicationContext()
		{
			NotifyIcon icon = new NotifyIcon();
			icon.Icon = Resources.autosizeimage16x16;
			icon.ContextMenuStrip = new ContextMenuStrip();

			this.miAutosize = icon.ContextMenuStrip.Items.Add("Autosize", Resources.autosizeimage16x16.ToBitmap(), this.OnAutosize);

			icon.ContextMenuStrip.Items.Add(new ToolStripSeparator());

			icon.ContextMenuStrip.Items.Add("Settings...", null, this.OnQuit);
			icon.ContextMenuStrip.Items.Add("Quit", null, this.OnQuit);

			icon.ContextMenuStrip.Opening += this.ContextMenuStripOnOpening;

			icon.Visible = true;

			this.notifyIcon = icon;
		}

		private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs)
		{
			//Size needSize = new Size(1920, 1080);

			Image image = Clipboard.GetImage();
			if (image == null)
			{
				this.miAutosize.Text = "Autosize (no image in clipboard)";
				this.miAutosize.Enabled = false;
			}
			else
			{
				this.miAutosize.Text = $"Autosize [{image.Width}x{image.Height}] => [{this.needSize.Width}x{this.needSize.Height}]";
				this.miAutosize.Enabled = image.Width > this.needSize.Width || image.Height > this.needSize.Height;
			}
		}

		private void OnAutosize(object sender, EventArgs e)
		{
			Image image = Clipboard.GetImage();
			if (image == null) return;
			if (this.needSize.Width == 0) return;
			if (this.needSize.Height == 0) return;

			double ratioX = (double)image.Width / this.needSize.Width;
			double ratioY = (double)image.Height / this.needSize.Height;
			double ratio = Math.Max(ratioX, ratioY);
			if (ratio < Double.Epsilon) return;

			Bitmap bitmap = ResizeImage(image, (int)(image.Width / ratio), (int)(image.Height / ratio));
			Clipboard.SetImage(bitmap);
		}

		/// <summary>
		/// Resize the image to the specified width and height.
		/// </summary>
		/// <param name="image">The image to resize.</param>
		/// <param name="width">The width to resize to.</param>
		/// <param name="height">The height to resize to.</param>
		/// <returns>The resized image.</returns>
		private static Bitmap ResizeImage(Image image, int width, int height)
		{
			Rectangle destRect = new Rectangle(0, 0, width, height);
			Bitmap destImage = new Bitmap(width, height);

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			using (Graphics graphics = Graphics.FromImage(destImage))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

				using (ImageAttributes wrapMode = new ImageAttributes())
				{
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}

			return destImage;
		}

		private void OnQuit(object sender, EventArgs e)
		{
			this.notifyIcon.Visible = false;

			Application.Exit();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.notifyIcon.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
