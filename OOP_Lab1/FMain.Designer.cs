namespace OOP_Lab1
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCanvas = new Panel();
            panelTools = new Panel();
            buttonCreateTriangle = new Button();
            buttonCreateSquare = new Button();
            buttonCoarseUp = new Button();
            buttonFineUp = new Button();
            buttonCoarseDown = new Button();
            buttonFineDown = new Button();
            buttonCollapse = new Button();
            buttonCoarseRight = new Button();
            buttonFineRight = new Button();
            buttonExpand = new Button();
            buttonFineLeft = new Button();
            buttonCoarseLeft = new Button();
            buttonShowObject = new Button();
            buttonHideObject = new Button();
            buttonCreateCircle = new Button();
            ObjectComboBox = new ComboBox();
            labelObjects = new Label();
            buttonCreateEmblem = new Button();
            panelTools.SuspendLayout();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = Color.White;
            panelCanvas.BorderStyle = BorderStyle.FixedSingle;
            panelCanvas.Location = new Point(0, 0);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(610, 436);
            panelCanvas.TabIndex = 0;
            // 
            // panelTools
            // 
            panelTools.Controls.Add(buttonCreateEmblem);
            panelTools.Controls.Add(buttonCreateTriangle);
            panelTools.Controls.Add(buttonCreateSquare);
            panelTools.Controls.Add(buttonCoarseUp);
            panelTools.Controls.Add(buttonFineUp);
            panelTools.Controls.Add(buttonCoarseDown);
            panelTools.Controls.Add(buttonFineDown);
            panelTools.Controls.Add(buttonCollapse);
            panelTools.Controls.Add(buttonCoarseRight);
            panelTools.Controls.Add(buttonFineRight);
            panelTools.Controls.Add(buttonExpand);
            panelTools.Controls.Add(buttonFineLeft);
            panelTools.Controls.Add(buttonCoarseLeft);
            panelTools.Controls.Add(buttonShowObject);
            panelTools.Controls.Add(buttonHideObject);
            panelTools.Controls.Add(buttonCreateCircle);
            panelTools.Controls.Add(ObjectComboBox);
            panelTools.Controls.Add(labelObjects);
            panelTools.Location = new Point(610, 0);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(226, 434);
            panelTools.TabIndex = 1;
            // 
            // buttonCreateTriangle
            // 
            buttonCreateTriangle.BackgroundImage = Properties.Resources.triangle;
            buttonCreateTriangle.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCreateTriangle.Location = new Point(88, 321);
            buttonCreateTriangle.Name = "buttonCreateTriangle";
            buttonCreateTriangle.Size = new Size(32, 32);
            buttonCreateTriangle.TabIndex = 16;
            buttonCreateTriangle.UseVisualStyleBackColor = true;
            buttonCreateTriangle.Click += buttonCreateTriangle_Click;
            // 
            // buttonCreateSquare
            // 
            buttonCreateSquare.BackgroundImage = Properties.Resources.square;
            buttonCreateSquare.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCreateSquare.Location = new Point(50, 321);
            buttonCreateSquare.Name = "buttonCreateSquare";
            buttonCreateSquare.Size = new Size(32, 32);
            buttonCreateSquare.TabIndex = 15;
            buttonCreateSquare.UseVisualStyleBackColor = true;
            buttonCreateSquare.Click += buttonCreateSquare_Click;
            // 
            // buttonCoarseUp
            // 
            buttonCoarseUp.BackgroundImage = Properties.Resources.doubleup;
            buttonCoarseUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCoarseUp.ForeColor = SystemColors.ButtonHighlight;
            buttonCoarseUp.Location = new Point(95, 75);
            buttonCoarseUp.Name = "buttonCoarseUp";
            buttonCoarseUp.Size = new Size(32, 32);
            buttonCoarseUp.TabIndex = 14;
            buttonCoarseUp.UseVisualStyleBackColor = true;
            buttonCoarseUp.Click += buttonCoarseUp_Click;
            // 
            // buttonFineUp
            // 
            buttonFineUp.BackgroundImage = Properties.Resources.up;
            buttonFineUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFineUp.ForeColor = SystemColors.ButtonHighlight;
            buttonFineUp.Location = new Point(95, 113);
            buttonFineUp.Name = "buttonFineUp";
            buttonFineUp.Size = new Size(32, 32);
            buttonFineUp.TabIndex = 13;
            buttonFineUp.UseVisualStyleBackColor = true;
            buttonFineUp.Click += buttonFineUp_Click;
            // 
            // buttonCoarseDown
            // 
            buttonCoarseDown.BackgroundImage = Properties.Resources.doubledown;
            buttonCoarseDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCoarseDown.ForeColor = SystemColors.ButtonHighlight;
            buttonCoarseDown.Location = new Point(95, 288);
            buttonCoarseDown.Name = "buttonCoarseDown";
            buttonCoarseDown.Size = new Size(32, 32);
            buttonCoarseDown.TabIndex = 12;
            buttonCoarseDown.UseVisualStyleBackColor = true;
            buttonCoarseDown.Click += buttonCoarseDown_Click;
            // 
            // buttonFineDown
            // 
            buttonFineDown.BackgroundImage = Properties.Resources.down;
            buttonFineDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFineDown.ForeColor = SystemColors.ButtonHighlight;
            buttonFineDown.Location = new Point(95, 250);
            buttonFineDown.Name = "buttonFineDown";
            buttonFineDown.Size = new Size(32, 32);
            buttonFineDown.TabIndex = 11;
            buttonFineDown.UseVisualStyleBackColor = true;
            buttonFineDown.Click += buttonFineDown_Click;
            // 
            // buttonCollapse
            // 
            buttonCollapse.BackgroundImage = Properties.Resources.minus;
            buttonCollapse.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCollapse.ForeColor = SystemColors.ButtonHighlight;
            buttonCollapse.Location = new Point(88, 199);
            buttonCollapse.Name = "buttonCollapse";
            buttonCollapse.Size = new Size(45, 45);
            buttonCollapse.TabIndex = 10;
            buttonCollapse.UseVisualStyleBackColor = true;
            buttonCollapse.Click += buttonCollapse_Click;
            // 
            // buttonCoarseRight
            // 
            buttonCoarseRight.BackgroundImage = Properties.Resources.doubleright;
            buttonCoarseRight.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCoarseRight.ForeColor = SystemColors.ButtonHighlight;
            buttonCoarseRight.Location = new Point(177, 180);
            buttonCoarseRight.Name = "buttonCoarseRight";
            buttonCoarseRight.Size = new Size(32, 32);
            buttonCoarseRight.TabIndex = 9;
            buttonCoarseRight.UseVisualStyleBackColor = true;
            buttonCoarseRight.Click += buttonCoarseRight_Click;
            // 
            // buttonFineRight
            // 
            buttonFineRight.BackgroundImage = Properties.Resources.right;
            buttonFineRight.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFineRight.ForeColor = SystemColors.ButtonHighlight;
            buttonFineRight.Location = new Point(139, 180);
            buttonFineRight.Name = "buttonFineRight";
            buttonFineRight.Size = new Size(32, 32);
            buttonFineRight.TabIndex = 8;
            buttonFineRight.UseVisualStyleBackColor = true;
            buttonFineRight.Click += buttonFineRight_Click;
            // 
            // buttonExpand
            // 
            buttonExpand.BackgroundImage = Properties.Resources.plus;
            buttonExpand.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExpand.ForeColor = SystemColors.ButtonHighlight;
            buttonExpand.Location = new Point(88, 151);
            buttonExpand.Name = "buttonExpand";
            buttonExpand.Size = new Size(45, 45);
            buttonExpand.TabIndex = 7;
            buttonExpand.UseVisualStyleBackColor = true;
            buttonExpand.Click += buttonExpand_Click;
            // 
            // buttonFineLeft
            // 
            buttonFineLeft.BackgroundImage = Properties.Resources.left;
            buttonFineLeft.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFineLeft.ForeColor = SystemColors.ButtonHighlight;
            buttonFineLeft.Location = new Point(50, 180);
            buttonFineLeft.Name = "buttonFineLeft";
            buttonFineLeft.Size = new Size(32, 32);
            buttonFineLeft.TabIndex = 6;
            buttonFineLeft.UseVisualStyleBackColor = true;
            buttonFineLeft.Click += buttonFineLeft_Click;
            // 
            // buttonCoarseLeft
            // 
            buttonCoarseLeft.BackgroundImage = Properties.Resources.doubleleft;
            buttonCoarseLeft.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCoarseLeft.ForeColor = SystemColors.ButtonHighlight;
            buttonCoarseLeft.Location = new Point(12, 180);
            buttonCoarseLeft.Name = "buttonCoarseLeft";
            buttonCoarseLeft.Size = new Size(32, 32);
            buttonCoarseLeft.TabIndex = 5;
            buttonCoarseLeft.UseVisualStyleBackColor = true;
            buttonCoarseLeft.Click += buttonCoarseLeft_Click;
            // 
            // buttonShowObject
            // 
            buttonShowObject.Location = new Point(12, 391);
            buttonShowObject.Name = "buttonShowObject";
            buttonShowObject.Size = new Size(203, 29);
            buttonShowObject.TabIndex = 4;
            buttonShowObject.Text = "Показати об'єкт";
            buttonShowObject.UseVisualStyleBackColor = true;
            buttonShowObject.Click += buttonShowObject_Click;
            // 
            // buttonHideObject
            // 
            buttonHideObject.Location = new Point(12, 356);
            buttonHideObject.Name = "buttonHideObject";
            buttonHideObject.Size = new Size(203, 29);
            buttonHideObject.TabIndex = 3;
            buttonHideObject.Text = "Приховати об'єкт";
            buttonHideObject.UseVisualStyleBackColor = true;
            buttonHideObject.Click += buttonHideObject_Click;
            // 
            // buttonCreateCircle
            // 
            buttonCreateCircle.BackgroundImage = Properties.Resources.circle;
            buttonCreateCircle.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCreateCircle.Location = new Point(12, 321);
            buttonCreateCircle.Name = "buttonCreateCircle";
            buttonCreateCircle.Size = new Size(32, 32);
            buttonCreateCircle.TabIndex = 2;
            buttonCreateCircle.UseVisualStyleBackColor = true;
            buttonCreateCircle.Click += buttonCreateCircle_Click;
            // 
            // ObjectComboBox
            // 
            ObjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ObjectComboBox.FormattingEnabled = true;
            ObjectComboBox.Location = new Point(12, 41);
            ObjectComboBox.Name = "ObjectComboBox";
            ObjectComboBox.Size = new Size(203, 28);
            ObjectComboBox.TabIndex = 1;
            ObjectComboBox.SelectedIndexChanged += ObjectComboBox_SelectedIndexChanged;
            // 
            // labelObjects
            // 
            labelObjects.AutoSize = true;
            labelObjects.Location = new Point(12, 18);
            labelObjects.Name = "labelObjects";
            labelObjects.Size = new Size(121, 20);
            labelObjects.TabIndex = 0;
            labelObjects.Text = "Перелік об'єктів";
            // 
            // buttonCreateEmblem
            // 
            buttonCreateEmblem.Location = new Point(127, 321);
            buttonCreateEmblem.Name = "buttonCreateEmblem";
            buttonCreateEmblem.Size = new Size(88, 32);
            buttonCreateEmblem.TabIndex = 17;
            buttonCreateEmblem.Text = "Емблема";
            buttonCreateEmblem.UseVisualStyleBackColor = true;
            buttonCreateEmblem.Click += buttonCreateEmblem_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 433);
            Controls.Add(panelTools);
            Controls.Add(panelCanvas);
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №1 - Приходько";
            panelTools.ResumeLayout(false);
            panelTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCanvas;
        private Panel panelTools;
        private Button buttonShowObject;
        private Button buttonHideObject;
        private Button buttonCreateCircle;
        private Button buttonCreateSquare;
        private Button buttonCreateTriangle;
        private ComboBox ObjectComboBox;
        private Label labelObjects;
        private Button buttonCoarseUp;
        private Button buttonFineUp;
        private Button buttonCoarseDown;
        private Button buttonFineDown;
        private Button buttonCollapse;
        private Button buttonCoarseRight;
        private Button buttonFineRight;
        private Button buttonExpand;
        private Button buttonFineLeft;
        private Button buttonCoarseLeft;
        private Button buttonCreateEmblem;
    }
}