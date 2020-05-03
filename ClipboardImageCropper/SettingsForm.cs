using System.Drawing;
using System.Windows.Forms;
using ClipboardImageCropper.Properties;

namespace ClipboardImageCropper
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			this.InitializeComponent();
			this.Icon = Resources.autosizeimage;
		}

		public SettingsForm(Sizes sizes) : this()
		{
			foreach (Size size in sizes.List)
			{
				ListViewItem item = this.lvResolutions.Items.Add($"{size.Width} x {size.Height}");
				item.Tag = size;
			}
		}

		private void lvResolutions_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.pnlTextBoxes.Enabled = this.lvResolutions.SelectedItems.Count > 0;
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			ListViewItem item = this.lvResolutions.Items.Add("<Новый>");
			item.Selected = true;
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{

		}

		private void tbWidth_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void tbHeight_TextChanged(object sender, System.EventArgs e)
		{

		}
	}
}
