using System.Windows.Forms;

namespace Lab_11___Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.plusMinus = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.backSpace = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.entryDisplay = new System.Windows.Forms.RichTextBox();
            this.operandsDisplay = new System.Windows.Forms.RichTextBox();
            this.emptyButton1 = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plusMinus
            // 
            this.plusMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.plusMinus.BackColor = System.Drawing.SystemColors.Window;
            this.plusMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plusMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.plusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.plusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusMinus.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinus.Location = new System.Drawing.Point(5, 406);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(92, 50);
            this.plusMinus.TabIndex = 0;
            this.plusMinus.Text = "+/-";
            this.plusMinus.UseVisualStyleBackColor = false;
            this.plusMinus.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // decimalPoint
            // 
            this.decimalPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decimalPoint.BackColor = System.Drawing.SystemColors.Window;
            this.decimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.decimalPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.decimalPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.decimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimalPoint.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalPoint.Location = new System.Drawing.Point(201, 406);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(92, 50);
            this.decimalPoint.TabIndex = 1;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.decimal_Click);
            // 
            // zero
            // 
            this.zero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zero.BackColor = System.Drawing.SystemColors.Window;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(103, 406);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(92, 50);
            this.zero.TabIndex = 2;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // equals
            // 
            this.equals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.equals.BackColor = System.Drawing.SystemColors.Window;
            this.equals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.equals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.equals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equals.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(299, 406);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(92, 50);
            this.equals.TabIndex = 3;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // addition
            // 
            this.addition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addition.BackColor = System.Drawing.SystemColors.Window;
            this.addition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addition.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(299, 350);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(92, 50);
            this.addition.TabIndex = 4;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.Add_Click);
            // 
            // subtraction
            // 
            this.subtraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subtraction.BackColor = System.Drawing.SystemColors.Window;
            this.subtraction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.subtraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.subtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtraction.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(299, 294);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(92, 50);
            this.subtraction.TabIndex = 5;
            this.subtraction.Text = "–";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.Subtract_click);
            // 
            // multiplication
            // 
            this.multiplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplication.BackColor = System.Drawing.SystemColors.Window;
            this.multiplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.multiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplication.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(299, 241);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(92, 50);
            this.multiplication.TabIndex = 6;
            this.multiplication.Text = "×";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.Multiply_click);
            // 
            // division
            // 
            this.division.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.division.BackColor = System.Drawing.SystemColors.Window;
            this.division.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.division.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.division.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(299, 185);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(92, 50);
            this.division.TabIndex = 7;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.Divide_click);
            // 
            // backSpace
            // 
            this.backSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backSpace.BackColor = System.Drawing.Color.White;
            this.backSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backSpace.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.backSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.backSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backSpace.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSpace.ForeColor = System.Drawing.Color.White;
            this.backSpace.Image = ((System.Drawing.Image)(resources.GetObject("backSpace.Image")));
            this.backSpace.Location = new System.Drawing.Point(299, 132);
            this.backSpace.Name = "backSpace";
            this.backSpace.Size = new System.Drawing.Size(92, 50);
            this.backSpace.TabIndex = 8;
            this.backSpace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.backSpace.UseVisualStyleBackColor = false;
            this.backSpace.Click += new System.EventHandler(this.Backspace_clicked);
            // 
            // three
            // 
            this.three.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.three.BackColor = System.Drawing.SystemColors.Window;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.three.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(201, 350);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(92, 50);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // six
            // 
            this.six.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.six.BackColor = System.Drawing.SystemColors.Window;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.six.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(201, 294);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(92, 50);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // nine
            // 
            this.nine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nine.BackColor = System.Drawing.SystemColors.Window;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(201, 241);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(92, 50);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.squareRoot.BackColor = System.Drawing.SystemColors.Window;
            this.squareRoot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.squareRoot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.squareRoot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.squareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.squareRoot.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareRoot.Location = new System.Drawing.Point(201, 185);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(92, 50);
            this.squareRoot.TabIndex = 13;
            this.squareRoot.Text = "²√x";
            this.squareRoot.UseVisualStyleBackColor = false;
            this.squareRoot.Click += new System.EventHandler(this.SquareRoot_click);
            // 
            // two
            // 
            this.two.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.two.BackColor = System.Drawing.SystemColors.Window;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.two.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(103, 350);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(92, 50);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // five
            // 
            this.five.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.five.BackColor = System.Drawing.SystemColors.Window;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.five.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(103, 294);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(92, 50);
            this.five.TabIndex = 15;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // eight
            // 
            this.eight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eight.BackColor = System.Drawing.SystemColors.Window;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(103, 241);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(92, 50);
            this.eight.TabIndex = 16;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // square
            // 
            this.square.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.square.BackColor = System.Drawing.SystemColors.Window;
            this.square.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(103, 185);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(92, 50);
            this.square.TabIndex = 17;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.Square_click);
            // 
            // one
            // 
            this.one.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.one.BackColor = System.Drawing.SystemColors.Window;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.one.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(5, 350);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(92, 50);
            this.one.TabIndex = 18;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // four
            // 
            this.four.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.four.BackColor = System.Drawing.SystemColors.Window;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.four.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(5, 294);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(92, 50);
            this.four.TabIndex = 19;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // seven
            // 
            this.seven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seven.BackColor = System.Drawing.SystemColors.Window;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(5, 241);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(92, 50);
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reciprocal.BackColor = System.Drawing.Color.White;
            this.reciprocal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reciprocal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reciprocal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.reciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reciprocal.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciprocal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reciprocal.Location = new System.Drawing.Point(5, 185);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(92, 50);
            this.reciprocal.TabIndex = 21;
            this.reciprocal.Text = "1/x";
            this.reciprocal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.reciprocal.UseVisualStyleBackColor = false;
            this.reciprocal.Click += new System.EventHandler(this.Reciprocal_click);
            // 
            // clearAll
            // 
            this.clearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAll.BackColor = System.Drawing.SystemColors.Window;
            this.clearAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearAll.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(201, 132);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(92, 50);
            this.clearAll.TabIndex = 22;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.Clear_Click);
            // 
            // entryDisplay
            // 
            this.entryDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.entryDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.entryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryDisplay.Font = new System.Drawing.Font("Times New Roman", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDisplay.Location = new System.Drawing.Point(0, 74);
            this.entryDisplay.Multiline = false;
            this.entryDisplay.Name = "entryDisplay";
            this.entryDisplay.ReadOnly = true;
            this.entryDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.entryDisplay.Size = new System.Drawing.Size(391, 52);
            this.entryDisplay.TabIndex = 23;
            this.entryDisplay.Text = "0";
            this.entryDisplay.WordWrap = false;
            // 
            // operandsDisplay
            // 
            this.operandsDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.operandsDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.operandsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operandsDisplay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandsDisplay.Location = new System.Drawing.Point(0, 35);
            this.operandsDisplay.Name = "operandsDisplay";
            this.operandsDisplay.ReadOnly = true;
            this.operandsDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.operandsDisplay.Size = new System.Drawing.Size(391, 24);
            this.operandsDisplay.TabIndex = 24;
            this.operandsDisplay.Text = "";
            // 
            // emptyButton1
            // 
            this.emptyButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.emptyButton1.BackColor = System.Drawing.SystemColors.Window;
            this.emptyButton1.Enabled = false;
            this.emptyButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.emptyButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.emptyButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.emptyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emptyButton1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyButton1.Location = new System.Drawing.Point(5, 132);
            this.emptyButton1.Name = "emptyButton1";
            this.emptyButton1.Size = new System.Drawing.Size(92, 50);
            this.emptyButton1.TabIndex = 25;
            this.emptyButton1.UseVisualStyleBackColor = false;
            // 
            // clearEntry
            // 
            this.clearEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearEntry.BackColor = System.Drawing.SystemColors.Window;
            this.clearEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearEntry.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry.Location = new System.Drawing.Point(103, 132);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(92, 50);
            this.clearEntry.TabIndex = 26;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(393, 462);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.emptyButton1);
            this.Controls.Add(this.operandsDisplay);
            this.Controls.Add(this.entryDisplay);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.one);
            this.Controls.Add(this.square);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.five);
            this.Controls.Add(this.two);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.backSpace);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.plusMinus);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private Button zero;
        private Button backSpace;
        private Button three;
        private Button six;
        private Button nine;
        private Button two;
        private Button five;
        private Button eight;
        private Button one;
        private Button four;
        private Button seven;
        private Button clearAll;
        private Button emptyButton1;
        private Button clearEntry;
        internal RichTextBox entryDisplay;
        internal RichTextBox operandsDisplay;
        public Button equals;
        public Button addition;
        public Button subtraction;
        public Button multiplication;
        public Button division;
        public Button squareRoot;
        public Button square;
        public Button reciprocal;
        public Button plusMinus;
        public Button decimalPoint;
    }
}