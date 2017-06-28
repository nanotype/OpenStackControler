using OpenStack;
using OpenStack.Compute.v2_1;
using System.Windows.Forms;

namespace TestOpenStack
{
    public partial class Glance : Form
    {
        private ComputeService compute = new ComputeService(connect.GetConnection(), "regionOne");

        public Glance()
        {
            InitializeComponent();
            listImage();
            listFlavor();
        }

  /***********************************************************************************************************/
 /****************************************** Section Image **************************************************/
/***********************************************************************************************************/
        public async void listImage()
        {
            IPage<Image> listImage = await compute.ListImagesAsync();
            foreach(Image image in listImage)
            {
                DGV_list_image.Rows.Add( image.Id, image.Name);
            }
        }

        private async void selectImage(object sender, DataGridViewCellEventArgs e)
        {
            if ((string)DGV_list_image.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Identifier searchImageId = new Identifier((Identifier)DGV_list_image.SelectedRows[0].Cells[0].Value);

                Image image = await compute.GetImageAsync(searchImageId);

                L_id.Text ="ID : " + image.Id;
                L_nom.Text = image.Name;
                L_minDiscSize.Text += image.MinimumDiskSize;
                L_type.Text += image.Type;
                L_date_creation.Text += image.Created;
            }
        }

        /**************************************************************************************************************/
        /******************************************** Section Flavor **************************************************/
        /**************************************************************************************************************/
        private async void listFlavor()
        {
            IPage<Flavor> listFlavor = await compute.ListFlavorsAsync();
            foreach(Flavor flavor in listFlavor)
            {
                DGV_list_flavor.Rows.Add(flavor.Id, flavor.Name);
            }
        }

        private async void selectFlavor(object sender, DataGridViewCellEventArgs e)
        {
            if ((string)DGV_list_flavor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Identifier searchFlavorId = new Identifier((Identifier)DGV_list_flavor.SelectedRows[0].Cells[0].Value);
                Flavor flavor = await compute.GetFlavorAsync(searchFlavorId);

                L_flavor_diskSize.Text = flavor.DiskSize.ToString();
                L_flavor_id.Text = flavor.Id.ToString();
                L_flavor_memorySize.Text = flavor.MemorySize.ToString();
                L_flavor_name.Text = flavor.Name.ToString();
                L_flavor_swapSize.Text = flavor.SwapSize.ToString();
                L_flavor_virtualCPUs.Text = flavor.VirtualCPUs.ToString();
            }
        }

        private void Glance_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}