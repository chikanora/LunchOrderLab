using System.CodeDom;

namespace LunchOrderLab
{
    public partial class frmLunchOrder : Form
    {
        // Creating constant variables for the food prices
        const double hamburgerPrice = 6.95;
        const double pizzaPrice = 5.95;
        const double saladPrice = 4.95;

        // Creating constant variables for the add-on toppings
        // Hamburger add-ons
        const double LETTUCE_TOMATO_ONION = 0.75;
        const double KETCHUP_MUSTARD_MAYONAISE = 0.75;
        const double FRENCH_FRIES = 0.75;

        // Pizza add-ons
        const double PEPPERONI = 0.50;
        const double SAUSAGE = 0.50;
        const double OLIVES = 0.50;

        // Salad add-ons
        const double CROUTONS = 0.25;
        const double BACON_BITS = 0.25;
        const double BREAD_STICKS = 0.25;

        // Creating variables for the subtotal, tax, and grand total
        double subTotal = 0;
        double tax = 0.05; // 5% tax
        double taxPrice = 0;
        double orderTotal = 0;

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {

        }

        private void rdoBtnHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnHamburger.Checked) // If selected, change the text from add-ons
            {
                grpBoxAddOnItems.Text = "Add-on items ($0.75/each)";
                chkBoxAddOn1.Text = "Lettuce, tomato, and onions";
                chkBoxAddOn2.Text = "Ketchup, mustard, and mayonaise";
                chkBoxAddOn3.Text = "French fries";

                // Reverts back to default unchecked
                chkBoxAddOn1.Checked = false;
                chkBoxAddOn2.Checked = false;
                chkBoxAddOn3.Checked = false;
            }
        }

        private void rdoBtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnPizza.Checked) // If selected, change the text from add-ons
            {
                grpBoxAddOnItems.Text = "Add-on items ($0.50/each)";
                chkBoxAddOn1.Text = "Pepperoni";
                chkBoxAddOn2.Text = "Sausage";
                chkBoxAddOn3.Text = "Olives";

                // Reverts back to default unchecked
                chkBoxAddOn1.Checked = false;
                chkBoxAddOn2.Checked = false;
                chkBoxAddOn3.Checked = false;
            }
        }

        private void rdoBtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnSalad.Checked) // If selected, change the text from add-ons
            {
                grpBoxAddOnItems.Text = "Add-on items ($0.25/each)";
                chkBoxAddOn1.Text = "Croutons";
                chkBoxAddOn2.Text = "Bacon bits";
                chkBoxAddOn3.Text = "Bread sticks";

                // Reverts back to default unchecked
                chkBoxAddOn1.Checked = false;
                chkBoxAddOn2.Checked = false;
                chkBoxAddOn3.Checked = false;
            }
        }

        // Price calculation function
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Price variables for the food and topping selections
            double foodPrice = 0;
            double addOnPrice = 0;

            if (rdoBtnHamburger.Checked)
            {
                // Adding on the hamburger price onto the food price
                foodPrice += hamburgerPrice;

                if (chkBoxAddOn1.Checked) // LETTUCE, TOMATO, AND ONIONS
                {
                    addOnPrice += LETTUCE_TOMATO_ONION;
                }

                if (chkBoxAddOn2.Checked) // KETCHUP, MUSTARD, AND MAYONAISE
                {
                    addOnPrice += KETCHUP_MUSTARD_MAYONAISE;
                }

                if (chkBoxAddOn3.Checked) // FRENCH FRIES
                {
                    addOnPrice += FRENCH_FRIES;
                }
            }
            else if (rdoBtnPizza.Checked)
            {
                foodPrice += pizzaPrice;

                if (chkBoxAddOn1.Checked) // PEPPERONI
                {
                    addOnPrice += PEPPERONI;
                }

                if (chkBoxAddOn2.Checked) // SAUSAGE
                {
                    addOnPrice += SAUSAGE;
                }

                if (chkBoxAddOn3.Checked) // OLIVES
                {
                    addOnPrice += OLIVES;
                }
            }
            else if (rdoBtnSalad.Checked)
            {
                foodPrice += saladPrice;

                if (chkBoxAddOn1.Checked) // CROUTONS
                {
                    addOnPrice += CROUTONS;
                }

                if (chkBoxAddOn2.Checked) // BACON BITS
                {
                    addOnPrice += BACON_BITS;
                }

                if (chkBoxAddOn3.Checked) // BREAD STICKS
                {
                    addOnPrice += BREAD_STICKS;
                }
            }

            // Displaying sub total price
            subTotal = foodPrice + addOnPrice;
            txtBoxSubtotal.Text = "$" + subTotal.ToString("F2");

            // Displaying the tax price
            taxPrice = subTotal * tax;
            txtBoxTax.Text = "$" + taxPrice.ToString("F2");

            // Displaying order total price
            orderTotal = subTotal + taxPrice;
            txtBoxOrderTotal.BackColor = Color.Yellow;
            txtBoxOrderTotal.Text = "$" + orderTotal.ToString("F2");
        }

        // Reverting back to default through the use of the reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reverting back to default selections for the radio buttons
            rdoBtnHamburger.Checked = true;
            rdoBtnPizza.Checked = false;
            rdoBtnSalad.Checked = false;

            // Reverting back to default selections for the checkboxes
            chkBoxAddOn1.Checked = false;
            chkBoxAddOn2.Checked = false;
            chkBoxAddOn3.Checked = false;

            // Clearing the textboxes
            txtBoxSubtotal.Clear();
            txtBoxTax.Clear();
            txtBoxOrderTotal.BackColor = Color.White;
            txtBoxOrderTotal.Clear();
        }

        // Closing the application through the use of the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
