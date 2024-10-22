namespace trogdorthebudginator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //populate some test data
            populateform();
        }
        public void populateform()
        {
            lstbxcategories.Items.Add("Restartaunts");
            lstbxcategories.Items.Add("Burnination");
            lstbxcategories.Items.Add("Taxes");
        }

        private void lstbxcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //some dummy data to populate the datagridview
            if (lstbxcategories.SelectedItem == "Restartaunts")
            {
                itemsgrdview.Rows.Clear();
                itemsgrdview.Rows.Add("Peasantry Food", "10000");

            }
            if (lstbxcategories.SelectedItem == "Taxes")
            {
                itemsgrdview.Rows.Clear();
                itemsgrdview.Rows.Add("the king of town", "$40000");
                itemsgrdview.Rows.Add("the municipality", "$9999999");


            }
        }
    }
}