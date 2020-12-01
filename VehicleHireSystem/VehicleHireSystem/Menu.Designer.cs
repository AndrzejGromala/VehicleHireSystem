namespace VehicleHireSystem
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.radioVan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTotalButtons = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNett = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtNbOfDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panVan = new System.Windows.Forms.Panel();
            this.txtTailLiftVan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSideDoorVan = new System.Windows.Forms.TextBox();
            this.txtWheelBaseVan = new System.Windows.Forms.TextBox();
            this.txtCargoSpaceVan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panCar = new System.Windows.Forms.Panel();
            this.txtBodyTypeCars = new System.Windows.Forms.TextBox();
            this.txtNbSeatsCar = new System.Windows.Forms.TextBox();
            this.txtNbDoorsCar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panBoth = new System.Windows.Forms.Panel();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.lblNotAvailable = new System.Windows.Forms.Label();
            this.panelTotalButtons.SuspendLayout();
            this.panVan.SuspendLayout();
            this.panCar.SuspendLayout();
            this.panBoth.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCar.ForeColor = System.Drawing.Color.Aqua;
            this.radioCar.Location = new System.Drawing.Point(274, 28);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(50, 20);
            this.radioCar.TabIndex = 0;
            this.radioCar.Text = "Car";
            this.radioCar.UseVisualStyleBackColor = true;
            this.radioCar.CheckedChanged += new System.EventHandler(this.radioCar_CheckedChanged);
            // 
            // radioVan
            // 
            this.radioVan.AutoSize = true;
            this.radioVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVan.ForeColor = System.Drawing.Color.Aqua;
            this.radioVan.Location = new System.Drawing.Point(367, 28);
            this.radioVan.Name = "radioVan";
            this.radioVan.Size = new System.Drawing.Size(53, 20);
            this.radioVan.TabIndex = 1;
            this.radioVan.Text = "Van";
            this.radioVan.UseVisualStyleBackColor = true;
            this.radioVan.CheckedChanged += new System.EventHandler(this.radioVan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the type of vehicle";
            // 
            // panelTotalButtons
            // 
            this.panelTotalButtons.BackColor = System.Drawing.Color.Aqua;
            this.panelTotalButtons.Controls.Add(this.button2);
            this.panelTotalButtons.Controls.Add(this.btnCancel);
            this.panelTotalButtons.Controls.Add(this.label5);
            this.panelTotalButtons.Controls.Add(this.txtTotal);
            this.panelTotalButtons.Controls.Add(this.txtNett);
            this.panelTotalButtons.Controls.Add(this.txtVat);
            this.panelTotalButtons.Controls.Add(this.txtNbOfDays);
            this.panelTotalButtons.Controls.Add(this.label4);
            this.panelTotalButtons.Controls.Add(this.label3);
            this.panelTotalButtons.Controls.Add(this.label2);
            this.panelTotalButtons.Location = new System.Drawing.Point(45, 220);
            this.panelTotalButtons.Name = "panelTotalButtons";
            this.panelTotalButtons.Size = new System.Drawing.Size(486, 147);
            this.panelTotalButtons.TabIndex = 5;
            this.panelTotalButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTotalButtons_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(322, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "HIRE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(322, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Silver;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(131, 108);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // txtNett
            // 
            this.txtNett.BackColor = System.Drawing.Color.Silver;
            this.txtNett.Enabled = false;
            this.txtNett.Location = new System.Drawing.Point(131, 75);
            this.txtNett.Name = "txtNett";
            this.txtNett.Size = new System.Drawing.Size(100, 20);
            this.txtNett.TabIndex = 5;
            // 
            // txtVat
            // 
            this.txtVat.BackColor = System.Drawing.Color.Silver;
            this.txtVat.Enabled = false;
            this.txtVat.Location = new System.Drawing.Point(131, 42);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(100, 20);
            this.txtVat.TabIndex = 4;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // txtNbOfDays
            // 
            this.txtNbOfDays.BackColor = System.Drawing.Color.Silver;
            this.txtNbOfDays.Location = new System.Drawing.Point(131, 10);
            this.txtNbOfDays.Name = "txtNbOfDays";
            this.txtNbOfDays.Size = new System.Drawing.Size(100, 20);
            this.txtNbOfDays.TabIndex = 3;
            this.txtNbOfDays.TextChanged += new System.EventHandler(this.txtNbOfDays_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nett";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "VAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Of Days";
            // 
            // panVan
            // 
            this.panVan.Controls.Add(this.txtTailLiftVan);
            this.panVan.Controls.Add(this.label16);
            this.panVan.Controls.Add(this.txtSideDoorVan);
            this.panVan.Controls.Add(this.txtWheelBaseVan);
            this.panVan.Controls.Add(this.txtCargoSpaceVan);
            this.panVan.Controls.Add(this.label13);
            this.panVan.Controls.Add(this.label14);
            this.panVan.Controls.Add(this.label15);
            this.panVan.Location = new System.Drawing.Point(330, 64);
            this.panVan.Name = "panVan";
            this.panVan.Size = new System.Drawing.Size(210, 137);
            this.panVan.TabIndex = 14;
            this.panVan.Paint += new System.Windows.Forms.PaintEventHandler(this.panVan_Paint);
            // 
            // txtTailLiftVan
            // 
            this.txtTailLiftVan.BackColor = System.Drawing.Color.Cyan;
            this.txtTailLiftVan.Enabled = false;
            this.txtTailLiftVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTailLiftVan.Location = new System.Drawing.Point(118, 93);
            this.txtTailLiftVan.Name = "txtTailLiftVan";
            this.txtTailLiftVan.Size = new System.Drawing.Size(67, 20);
            this.txtTailLiftVan.TabIndex = 21;
            this.txtTailLiftVan.TextChanged += new System.EventHandler(this.txtTailLiftVan_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Cyan;
            this.label16.Location = new System.Drawing.Point(10, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Tail lift";
            // 
            // txtSideDoorVan
            // 
            this.txtSideDoorVan.BackColor = System.Drawing.Color.Cyan;
            this.txtSideDoorVan.Enabled = false;
            this.txtSideDoorVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSideDoorVan.Location = new System.Drawing.Point(118, 64);
            this.txtSideDoorVan.Name = "txtSideDoorVan";
            this.txtSideDoorVan.Size = new System.Drawing.Size(67, 20);
            this.txtSideDoorVan.TabIndex = 19;
            this.txtSideDoorVan.TextChanged += new System.EventHandler(this.txtSideDoorVan_TextChanged);
            // 
            // txtWheelBaseVan
            // 
            this.txtWheelBaseVan.BackColor = System.Drawing.Color.Cyan;
            this.txtWheelBaseVan.Enabled = false;
            this.txtWheelBaseVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWheelBaseVan.Location = new System.Drawing.Point(118, 34);
            this.txtWheelBaseVan.Name = "txtWheelBaseVan";
            this.txtWheelBaseVan.Size = new System.Drawing.Size(67, 20);
            this.txtWheelBaseVan.TabIndex = 18;
            this.txtWheelBaseVan.TextChanged += new System.EventHandler(this.txtWheelBaseVan_TextChanged);
            // 
            // txtCargoSpaceVan
            // 
            this.txtCargoSpaceVan.BackColor = System.Drawing.Color.Cyan;
            this.txtCargoSpaceVan.Enabled = false;
            this.txtCargoSpaceVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoSpaceVan.Location = new System.Drawing.Point(118, 6);
            this.txtCargoSpaceVan.Name = "txtCargoSpaceVan";
            this.txtCargoSpaceVan.Size = new System.Drawing.Size(67, 20);
            this.txtCargoSpaceVan.TabIndex = 17;
            this.txtCargoSpaceVan.TextChanged += new System.EventHandler(this.txtCargoSpaceVan_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Cyan;
            this.label13.Location = new System.Drawing.Point(10, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Side door";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Cyan;
            this.label14.Location = new System.Drawing.Point(10, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Wheel base";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Cyan;
            this.label15.Location = new System.Drawing.Point(8, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Cargo space  cubM";
            // 
            // panCar
            // 
            this.panCar.Controls.Add(this.txtBodyTypeCars);
            this.panCar.Controls.Add(this.txtNbSeatsCar);
            this.panCar.Controls.Add(this.txtNbDoorsCar);
            this.panCar.Controls.Add(this.label12);
            this.panCar.Controls.Add(this.label11);
            this.panCar.Controls.Add(this.label10);
            this.panCar.Location = new System.Drawing.Point(343, 64);
            this.panCar.Name = "panCar";
            this.panCar.Size = new System.Drawing.Size(172, 134);
            this.panCar.TabIndex = 6;
            this.panCar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBodyTypeCars
            // 
            this.txtBodyTypeCars.BackColor = System.Drawing.Color.Cyan;
            this.txtBodyTypeCars.Enabled = false;
            this.txtBodyTypeCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyTypeCars.Location = new System.Drawing.Point(94, 70);
            this.txtBodyTypeCars.Name = "txtBodyTypeCars";
            this.txtBodyTypeCars.Size = new System.Drawing.Size(67, 20);
            this.txtBodyTypeCars.TabIndex = 13;
            this.txtBodyTypeCars.TextChanged += new System.EventHandler(this.txtBodyTypeCars_TextChanged);
            // 
            // txtNbSeatsCar
            // 
            this.txtNbSeatsCar.BackColor = System.Drawing.Color.Cyan;
            this.txtNbSeatsCar.Enabled = false;
            this.txtNbSeatsCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbSeatsCar.Location = new System.Drawing.Point(94, 41);
            this.txtNbSeatsCar.Name = "txtNbSeatsCar";
            this.txtNbSeatsCar.Size = new System.Drawing.Size(67, 20);
            this.txtNbSeatsCar.TabIndex = 12;
            this.txtNbSeatsCar.TextChanged += new System.EventHandler(this.txtNbSeatsCar_TextChanged);
            // 
            // txtNbDoorsCar
            // 
            this.txtNbDoorsCar.BackColor = System.Drawing.Color.Cyan;
            this.txtNbDoorsCar.Enabled = false;
            this.txtNbDoorsCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbDoorsCar.Location = new System.Drawing.Point(94, 13);
            this.txtNbDoorsCar.Name = "txtNbDoorsCar";
            this.txtNbDoorsCar.Size = new System.Drawing.Size(67, 20);
            this.txtNbDoorsCar.TabIndex = 11;
            this.txtNbDoorsCar.TextChanged += new System.EventHandler(this.txtNbDoorsCar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Cyan;
            this.label12.Location = new System.Drawing.Point(9, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Body type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Cyan;
            this.label11.Location = new System.Drawing.Point(9, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Number of seats";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(9, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Number of dors";
            // 
            // panBoth
            // 
            this.panBoth.Controls.Add(this.txtManual);
            this.panBoth.Controls.Add(this.txtEngineSize);
            this.panBoth.Controls.Add(this.txtPrice);
            this.panBoth.Controls.Add(this.txtFuelType);
            this.panBoth.Controls.Add(this.label9);
            this.panBoth.Controls.Add(this.label8);
            this.panBoth.Controls.Add(this.label7);
            this.panBoth.Controls.Add(this.label6);
            this.panBoth.ForeColor = System.Drawing.Color.Black;
            this.panBoth.Location = new System.Drawing.Point(176, 64);
            this.panBoth.Name = "panBoth";
            this.panBoth.Size = new System.Drawing.Size(148, 137);
            this.panBoth.TabIndex = 15;
            this.panBoth.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtManual
            // 
            this.txtManual.BackColor = System.Drawing.Color.Cyan;
            this.txtManual.Enabled = false;
            this.txtManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManual.Location = new System.Drawing.Point(77, 93);
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(68, 20);
            this.txtManual.TabIndex = 23;
            this.txtManual.TextChanged += new System.EventHandler(this.txtManual_TextChanged);
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.BackColor = System.Drawing.Color.Cyan;
            this.txtEngineSize.Enabled = false;
            this.txtEngineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngineSize.Location = new System.Drawing.Point(77, 64);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(68, 20);
            this.txtEngineSize.TabIndex = 22;
            this.txtEngineSize.TextChanged += new System.EventHandler(this.txtEngineSize_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Cyan;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrice.Location = new System.Drawing.Point(77, 34);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(68, 20);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtFuelType
            // 
            this.txtFuelType.BackColor = System.Drawing.Color.Cyan;
            this.txtFuelType.Enabled = false;
            this.txtFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFuelType.Location = new System.Drawing.Point(77, 6);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(68, 20);
            this.txtFuelType.TabIndex = 20;
            this.txtFuelType.TextChanged += new System.EventHandler(this.txtFuelType_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(10, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Manual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(10, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Engine size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(10, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Price e/day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fuel type";
            // 
            // listBoxMain
            // 
            this.listBoxMain.BackColor = System.Drawing.Color.Cyan;
            this.listBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(45, 64);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(120, 121);
            this.listBoxMain.TabIndex = 16;
            this.listBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMain_MouseClick_1);
            this.listBoxMain.SelectedIndexChanged += new System.EventHandler(this.listBoxMain_SelectedIndexChanged);
            this.listBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxMain_MouseUp);
            // 
            // lblNotAvailable
            // 
            this.lblNotAvailable.AutoSize = true;
            this.lblNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAvailable.ForeColor = System.Drawing.Color.Red;
            this.lblNotAvailable.Location = new System.Drawing.Point(46, 45);
            this.lblNotAvailable.Name = "lblNotAvailable";
            this.lblNotAvailable.Size = new System.Drawing.Size(124, 16);
            this.lblNotAvailable.TabIndex = 17;
            this.lblNotAvailable.Text = "NOT AVAILABLE";
            this.lblNotAvailable.Click += new System.EventHandler(this.lblNotAvailable_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(563, 413);
            this.Controls.Add(this.lblNotAvailable);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.panBoth);
            this.Controls.Add(this.panVan);
            this.Controls.Add(this.panCar);
            this.Controls.Add(this.panelTotalButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioVan);
            this.Controls.Add(this.radioCar);
            this.Name = "Menu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.panelTotalButtons.ResumeLayout(false);
            this.panelTotalButtons.PerformLayout();
            this.panVan.ResumeLayout(false);
            this.panVan.PerformLayout();
            this.panCar.ResumeLayout(false);
            this.panCar.PerformLayout();
            this.panBoth.ResumeLayout(false);
            this.panBoth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.RadioButton radioVan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTotalButtons;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNett;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtNbOfDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panCar;
        private System.Windows.Forms.TextBox txtBodyTypeCars;
        private System.Windows.Forms.TextBox txtNbSeatsCar;
        private System.Windows.Forms.TextBox txtNbDoorsCar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panVan;
        private System.Windows.Forms.TextBox txtSideDoorVan;
        private System.Windows.Forms.TextBox txtWheelBaseVan;
        private System.Windows.Forms.TextBox txtCargoSpaceVan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panBoth;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTailLiftVan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Label lblNotAvailable;
    }
}

