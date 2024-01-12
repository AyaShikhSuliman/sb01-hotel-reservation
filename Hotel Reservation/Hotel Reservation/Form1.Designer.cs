
namespace Hotel_Reservation
{
    partial class Form1
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
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudAmountOfNights = new System.Windows.Forms.NumericUpDown();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lblAmountOfNights = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lbRoom = new System.Windows.Forms.ListBox();
            this.chbSmoking = new System.Windows.Forms.CheckBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblReservation = new System.Windows.Forms.Label();
            this.lbReservation = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfNights)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(155, 625);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(303, 33);
            this.btnReserve.TabIndex = 41;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(303, 31);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add Room";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudAmountOfNights
            // 
            this.nudAmountOfNights.Location = new System.Drawing.Point(284, 159);
            this.nudAmountOfNights.Name = "nudAmountOfNights";
            this.nudAmountOfNights.Size = new System.Drawing.Size(174, 22);
            this.nudAmountOfNights.TabIndex = 34;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(284, 111);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(174, 22);
            this.tbFullName.TabIndex = 33;
            // 
            // lblAmountOfNights
            // 
            this.lblAmountOfNights.AutoSize = true;
            this.lblAmountOfNights.Location = new System.Drawing.Point(152, 161);
            this.lblAmountOfNights.Name = "lblAmountOfNights";
            this.lblAmountOfNights.Size = new System.Drawing.Size(110, 16);
            this.lblAmountOfNights.TabIndex = 31;
            this.lblAmountOfNights.Text = "Amount of nights: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(152, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(114, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(398, 36);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Welcome to Hotel Califonia";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(152, 210);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(82, 16);
            this.lblRoomType.TabIndex = 43;
            this.lblRoomType.Text = "Room Type:";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(284, 207);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(174, 24);
            this.cbRoomType.TabIndex = 45;
            // 
            // lbRoom
            // 
            this.lbRoom.FormattingEnabled = true;
            this.lbRoom.ItemHeight = 16;
            this.lbRoom.Location = new System.Drawing.Point(155, 398);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(303, 196);
            this.lbRoom.TabIndex = 46;
            // 
            // chbSmoking
            // 
            this.chbSmoking.AutoSize = true;
            this.chbSmoking.Location = new System.Drawing.Point(284, 257);
            this.chbSmoking.Name = "chbSmoking";
            this.chbSmoking.Size = new System.Drawing.Size(82, 20);
            this.chbSmoking.TabIndex = 47;
            this.chbSmoking.Text = "Smoking";
            this.chbSmoking.UseVisualStyleBackColor = true;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(152, 354);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(47, 16);
            this.lblRooms.TabIndex = 48;
            this.lblRooms.Text = "Room:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(247, 643);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 51;
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Location = new System.Drawing.Point(517, 111);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(90, 16);
            this.lblReservation.TabIndex = 52;
            this.lblReservation.Text = "Reservations:";
            // 
            // lbReservation
            // 
            this.lbReservation.FormattingEnabled = true;
            this.lbReservation.ItemHeight = 16;
            this.lbReservation.Location = new System.Drawing.Point(520, 142);
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.Size = new System.Drawing.Size(303, 452);
            this.lbReservation.TabIndex = 53;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(659, 628);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 30);
            this.btnNext.TabIndex = 54;
            this.btnNext.Text = "Finish";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 702);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbReservation);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.chbSmoking);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudAmountOfNights);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lblAmountOfNights);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfNights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudAmountOfNights;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lblAmountOfNights;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.ListBox lbRoom;
        private System.Windows.Forms.CheckBox chbSmoking;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.ListBox lbReservation;
        private System.Windows.Forms.Button btnNext;
    }
}

