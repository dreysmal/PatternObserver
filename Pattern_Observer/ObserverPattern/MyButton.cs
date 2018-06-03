using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pattern_Observer
{
    sealed class MyButton : Button, IObserver
    {
        private readonly IObservable _form;

        private bool IsSubscribed;
        public MyButton(IObservable form1)
        {
            Size = new Size(150, 150);
            Font = new Font(FontFamily.GenericSansSerif, 16);
            Text = "Recieving" + Environment.NewLine + "notifications";
            BackColor = Color.DeepPink;

            _form = form1;
            _form.RegisterObserver(this);
            IsSubscribed = true;
            Click += IfClicked;
        }

        public void IfClicked(object sender, EventArgs eventArgs)
        {
            if (!IsSubscribed)
            {
                _form.RegisterObserver(this);
                Text = "Recieving" + Environment.NewLine + "notifications";
                IsSubscribed = true;
            }
            else
            {
                _form.RemoveObserver(this);
                Text = "Unsubcribed!";
                IsSubscribed = false;
            }    
        }

        public void Update(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Location = new Point(Location.X, Location.Y - 10);
                    break;
                case Direction.Right:
                    Location = new Point(Location.X + 10, Location.Y);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, Location.Y + 10);
                    break;
                case Direction.Left:
                    Location = new Point(Location.X - 10, Location.Y);
                    break;
            }
        }
    }
}
