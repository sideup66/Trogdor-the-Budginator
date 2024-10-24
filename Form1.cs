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

            //add a few months
            lstbxmonth.Items.Add("Jan");
            lstbxmonth.Items.Add("Feb");
            lstbxmonth.Items.Add("March");
        }

        private void lstbxcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxmonth.SelectedItem == "Jan")
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
                if (lstbxcategories.SelectedItem == "Burnination")
                {
                    itemsgrdview.Rows.Clear();
                    itemsgrdview.Rows.Add("The burninated peasants fund", "$40000");
                    itemsgrdview.Rows.Add("The maimed knights fund", "$9999999");
                    itemsgrdview.Rows.Add("Thatched roof cottages rebuilding", "$9999999");
                }
            }
            if (lstbxmonth.SelectedItem == "Feb")
            {
                if (lstbxcategories.SelectedItem == "Restartaunts")
                {
                    itemsgrdview.Rows.Clear();
                    itemsgrdview.Rows.Add("Peasantry Food", "10000");

                }
                if (lstbxcategories.SelectedItem == "Taxes")
                {
                    itemsgrdview.Rows.Clear();
                    itemsgrdview.Rows.Add("the king of town", "$40000");

                }
                if (lstbxcategories.SelectedItem == "Burnination")
                {
                    itemsgrdview.Rows.Clear();
                    itemsgrdview.Rows.Add("The burninated peasants fund", "$40000");
                    itemsgrdview.Rows.Add("The maimed knights fund", "$9999999");
                }
            }
        }
    }
}