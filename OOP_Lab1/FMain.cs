namespace OOP_Lab1
{
    public partial class FMain : Form
    {
        CEmblem[] emblem;

        const int SCALE_DEFAULT = 5;
        const int FINE_MOVE_DEFAULT = 1;
        const int COARSE_MOVE_DEFAULT = 10;
        const int ZERO_MOVE = 0;

        int ObjectCount = 0;
        int CurrentObjectIndex;
        string LastSelectedObj = "";

        public FMain()
        {
            InitializeComponent();
            emblem = new CEmblem[100];
        }

        private void buttonCreateCircle_Click(object sender, EventArgs e)
        {
            if (ObjectCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів.");
                return;
            }
            LastSelectedObj = "Circle";
            Graphics graphics = panelCanvas.CreateGraphics();
            CurrentObjectIndex = ObjectCount;
            emblem[CurrentObjectIndex] = new CEmblem(graphics,
                                                      panelCanvas.Width / 2,
                                                      panelCanvas.Height / 2,
                                                      50);
            emblem[CurrentObjectIndex].Show(LastSelectedObj);
            ObjectCount++;
            ObjectComboBox.Items.Add("Коло №" + (ObjectCount - 1).ToString());
            ObjectComboBox.SelectedIndex = ObjectCount - 1;
        }
        private void buttonCreateSquare_Click(object sender, EventArgs e)
        {
            if (ObjectCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів.");
                return;
            }
            LastSelectedObj = "Square";
            Graphics graphics = panelCanvas.CreateGraphics();
            CurrentObjectIndex = ObjectCount;
            emblem[CurrentObjectIndex] = new CEmblem(graphics,
                                                      panelCanvas.Width / 2,
                                                      panelCanvas.Height / 2,
                                                      50);
            emblem[CurrentObjectIndex].Show("Square");
            ObjectCount++;
            ObjectComboBox.Items.Add("Квадрат №" + (ObjectCount - 1).ToString());
            ObjectComboBox.SelectedIndex = ObjectCount - 1;
        }
        private void buttonCreateTriangle_Click(object sender, EventArgs e)
        {
            if (ObjectCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів.");
                return;
            }
            LastSelectedObj = "Triangle";
            Graphics graphics = panelCanvas.CreateGraphics();
            CurrentObjectIndex = ObjectCount;
            emblem[CurrentObjectIndex] = new CEmblem(graphics,
                                                      panelCanvas.Width / 2,
                                                      panelCanvas.Height / 2,
                                                      50);
            emblem[CurrentObjectIndex].Show("Triangle");
            ObjectCount++;
            ObjectComboBox.Items.Add("Трикутник №" + (ObjectCount - 1).ToString());
            ObjectComboBox.SelectedIndex = ObjectCount - 1;
        }
        private void buttonCreateEmblem_Click(object sender, EventArgs e)
        {
            if (ObjectCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів.");
                return;
            }
            LastSelectedObj = "Emblem";
            Graphics graphics = panelCanvas.CreateGraphics();
            CurrentObjectIndex = ObjectCount;
            emblem[CurrentObjectIndex] = new CEmblem(graphics,
                                                      panelCanvas.Width / 2,
                                                      panelCanvas.Height / 2,
                                                      50);
            emblem[CurrentObjectIndex].Show("Emblem");
            ObjectCount++;
            ObjectComboBox.Items.Add("Емблема №" + (ObjectCount - 1).ToString());
            ObjectComboBox.SelectedIndex = ObjectCount - 1;
        }
        private void buttonHideObject_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Hide(LastSelectedObj);
        }

        private void buttonShowObject_Click(object sender, EventArgs e)
        {
            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Show(LastSelectedObj);
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Expand(LastSelectedObj, SCALE_DEFAULT);
        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Collapse(LastSelectedObj, SCALE_DEFAULT);
        }

        private void buttonFineUp_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                      ZERO_MOVE,
                                     -FINE_MOVE_DEFAULT);
        }

        private void buttonFineDown_Click(object sender, EventArgs e)
        {
            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                     ZERO_MOVE,
                                     FINE_MOVE_DEFAULT);
        }

        private void buttonFineLeft_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                     -FINE_MOVE_DEFAULT,
                                     ZERO_MOVE);
        }

        private void buttonFineRight_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                     FINE_MOVE_DEFAULT,
                                     ZERO_MOVE);
        }

        private void buttonCoarseUp_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                      ZERO_MOVE,
                                     -COARSE_MOVE_DEFAULT);
        }

        private void buttonCoarseDown_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                     ZERO_MOVE,
                                     COARSE_MOVE_DEFAULT);
        }

        private void buttonCoarseLeft_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                    -COARSE_MOVE_DEFAULT,
                                     ZERO_MOVE);
        }

        private void buttonCoarseRight_Click(object sender, EventArgs e)
        {

            CurrentObjectIndex = ObjectComboBox.SelectedIndex;
            if ((CurrentObjectIndex > ObjectCount) || (CurrentObjectIndex < 0))
                return;
            emblem[CurrentObjectIndex].Move(LastSelectedObj,
                                     COARSE_MOVE_DEFAULT,
                                     ZERO_MOVE);
        }

        private void ObjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastSelectedObj = ObjectComboBox.SelectedItem.ToString()
                                                         .Split(" ")[0];
            switch (LastSelectedObj)
            {
                case "Коло":
                    LastSelectedObj = "Circle";
                    break;
                case "Квадрат":
                    LastSelectedObj = "Square";
                    break;
                case "Трикутник":
                    LastSelectedObj = "Triangle";
                    break;
                case "Емблема":
                    LastSelectedObj = "Emblem";
                    break;
            }
        }
    }
}