using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VehicleHireSystem
{
    public partial class Menu : Form
    {
       
        public static int selection = 0;

        public Menu()
        {
            InitializeComponent();
            //this below is just for text
           // listBoxMain.Items.Add("test");
            panelTotalButtons.Visible = false;
            //panel for both car and van
            panBoth.Visible = false;
            //panel for van
            panVan.Visible = false;
            //panel for car
            panCar.Visible = false;
            lblNotAvailable.Visible = false;




        }
       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
          
        }

        private void panelTotalButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNbDoorsCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panVan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewCarDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                if (radioCar.Checked)
            { 
                radioVan.Checked = false;

                if (listBoxMain.SelectedItem == null)
                {
                    listBoxMain.SelectedIndex = Classes.HireClass.displayCar.Count - 1;
                }
                else
                {
                    selection = listBoxMain.SelectedIndex;
                    
                    //getting the right shit from the array
                    //List<Classes.CarClass> displayCar = Classes.HireClass.radioCar();
                    txtFuelType.Text = Classes.HireClass.displayCar[selection].getFuelType();
                    txtPrice.Text = Classes.HireClass.displayCar[selection].getPrice().ToString();
                    txtEngineSize.Text = Classes.HireClass.displayCar[selection].getEngineSize().ToString();
                    if (Classes.HireClass.displayCar[selection].getManual() == true)
                        txtManual.Text = "Yes";
                    else txtManual.Text = "No";
                    txtNbDoorsCar.Text = Classes.HireClass.displayCar[selection].getNbOfDors().ToString();
                    txtNbSeatsCar.Text = Classes.HireClass.displayCar[selection].getNbOfSeats().ToString();
                    txtBodyTypeCars.Text = Classes.HireClass.displayCar[selection].getBodyType().ToString();
                    Classes.HireClass.radioCar()[selection].setDaysHired(33);
                }
            }
            if (radioVan.Checked)
                //radioCar.Checked = false;
            {
                if (listBoxMain.SelectedItem == null)
                { //this part solves the problem with clicking on the empty space
                    listBoxMain.SelectedIndex = Classes.HireClass.displayCar.Count - 1;
                }
                else
                {

                    selection = listBoxMain.SelectedIndex;
                    //List<Classes.VanClass> displayVan = Classes.HireClass.radioVan();

                    txtFuelType.Text = Classes.HireClass.displayVan[selection].getFuelType();
                    txtPrice.Text = Classes.HireClass.displayVan[selection].getPrice().ToString();
                    txtEngineSize.Text = Classes.HireClass.displayVan[selection].getEngineSize().ToString();
                    if (Classes.HireClass.displayVan[selection].getManual() == true)
                        txtManual.Text = "Yes";
                    else txtManual.Text = "No";
                    txtCargoSpaceVan.Text = Classes.HireClass.displayVan[selection].getCargoSpace().ToString();
                    if (Classes.HireClass.displayVan[selection].getWheelBase() == 'L')
                        txtWheelBaseVan.Text = "Long";
                    else txtWheelBaseVan.Text = "Short";
                    if (Classes.HireClass.displayVan[selection].getSideDors() == true)
                        txtSideDoorVan.Text = "Yes";
                    else txtSideDoorVan.Text = "No";
                    if (Classes.HireClass.displayVan[selection].getTailLift() == true)
                        txtTailLiftVan.Text = "Yes";
                    else txtTailLiftVan.Text = "No";
                }
            }
            //if (txtNbOfDays.Text.Length == 0)
            //{

            //}
            Classes.HireClass.price = double.Parse(txtPrice.Text);
            panelTotalButtons.Visible = true;
            
        }

        private void radioCar_CheckedChanged(object sender, EventArgs e)
        {
           

            txtNbOfDays.Clear();
            listBoxMain.Items.Clear();
            txtFuelType.Clear();
            txtPrice.Clear();
            txtEngineSize.Clear();
            txtManual.Clear();
            txtCargoSpaceVan.Clear();
            txtSideDoorVan.Clear();
            txtTailLiftVan.Clear();
            txtWheelBaseVan.Clear();
            txtNbOfDays.Clear();
            txtVat.Clear();
            txtNett.Clear();
            txtTotal.Clear();

            panBoth.Visible = true;
            panVan.Visible = false;
            panCar.Visible = true;
            List<Classes.CarClass> displayC = Classes.HireClass.radioCar();
            
            for (int i = 0; i < displayC.Count; i++)
            {
                String one = displayC[i].getMake();
                String two = displayC[i].getModel();
                listBoxMain.Items.Add(one + " " + two);
                

            }
            
        }

        private void radioVan_CheckedChanged(object sender, EventArgs e)
        {
           

            txtNbOfDays.Clear();
            listBoxMain.Items.Clear();
            txtFuelType.Clear();
            txtPrice.Clear();
            txtEngineSize.Clear();
            txtManual.Clear();
            txtNbDoorsCar.Clear();
            txtNbSeatsCar.Clear();
            txtBodyTypeCars.Clear();
            txtNbOfDays.Clear();
            txtVat.Clear();
            txtNett.Clear();
            txtTotal.Clear();
            panBoth.Visible = true;
            panCar.Visible = false;
            panVan.Visible = true;
            List<Classes.VanClass> displayV = Classes.HireClass.radioVan(); //le
            for (int i = 0; i < displayV.Count; i++)
            {
                String one = displayV[i].getMake();
                String two = displayV[i].getModel();
                listBoxMain.Items.Add(one + " " + two);
                

            }
        }

        private void txtFuelType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEngineSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtManual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNbSeatsCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBodyTypeCars_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCargoSpaceVan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWheelBaseVan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSideDoorVan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTailLiftVan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            listBoxMain.Items.Clear();
            txtFuelType.Clear();
            txtPrice.Clear();
            txtEngineSize.Clear();
            txtManual.Clear();
            txtNbDoorsCar.Clear();
            txtNbSeatsCar.Clear();
            txtBodyTypeCars.Clear();
            txtNbOfDays.Text = "";
            Classes.HireClass.nbOfDays = 0;
            txtVat.Clear();
            txtNett.Clear();
            txtTotal.Clear();
            txtCargoSpaceVan.Clear();
            txtSideDoorVan.Clear();
            txtTailLiftVan.Clear();
            txtWheelBaseVan.Clear();
        }

        private void txtNbOfDays_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(txtNbOfDays.Text, out result))
            {
                Classes.HireClass.nbOfDays = result;
            }//this part dolved the problem with app crashing and it works like try and catch block
            else
            {
                 Classes.HireClass.nbOfDays = int.Parse(txtNbOfDays.Text);
            }
            txtVat.Text = Classes.HireClass.CalculatingVat().ToString();
            txtNett.Text = Classes.HireClass.CalculatingNett().ToString();
            txtTotal.Text = Classes.HireClass.CalculatingTotal().ToString();
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
           if (radioCar.Checked)
            {
                Classes.HireClass.displayCar[selection].setDaysHired(int.Parse(txtNbOfDays.Text));
                MessageBox.Show("You have rented " + Classes.HireClass.displayCar[selection].getMake() +
                    " " + Classes.HireClass.displayCar[selection].getModel() + " for "
                    + (int.Parse(txtNbOfDays.Text))+" days");
            }
            if (radioVan.Checked)
           {
                Classes.HireClass.displayVan[selection].setDaysHired(int.Parse(txtNbOfDays.Text));
                MessageBox.Show("You have rented " + Classes.HireClass.displayVan[selection].getMake() +
                    " " + Classes.HireClass.displayVan[selection].getModel() + " for "
                    + (int.Parse(txtNbOfDays.Text)) + " days");
            }
            Classes.HireClass.UpdateVehicles(Classes.HireClass.displayCar, Classes.HireClass.displayVan);//this method is merged now
            
           
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void listBoxMain_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblNotAvailable_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMain_MouseClick_1(object sender, MouseEventArgs e)
        {
           
        }

        private void listBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioCar.Checked) //mouse up event controls the display of available or not

            {
                if (Classes.HireClass.displayCar[selection].getDaysHired() != 0)
                {
                    lblNotAvailable.Visible = true;
                }
                else lblNotAvailable.Visible = false;
            }
            if (radioVan.Checked)
            {
                if (Classes.HireClass.displayVan[selection].getDaysHired() != 0)
                {
                    lblNotAvailable.Visible = true;
                }
                else lblNotAvailable.Visible = false;
            }

        }
    }
}
