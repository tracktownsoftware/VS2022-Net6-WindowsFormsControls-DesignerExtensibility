using Net6WinFormControl;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Net6WinFormControl.Design
{
    public class MyButton2Designer : System.Windows.Forms.Design.ControlDesigner
    {
        MyButton2 _myButton2;
        private DesignerActionListCollection _actionLists;

        internal static void DontRemoveConstructor()
        {
            new MyButton2Designer();
        }

        public MyButton2Designer()
        {
        }

        public override void Initialize(System.ComponentModel.IComponent component)
        {
            base.Initialize(component);
            _myButton2 = component as MyButton2;
            if (_myButton2 != null)
            {
                _myButton2.Width = 200;
                _myButton2.Height = 125;
            }
        }

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == _actionLists)
                {
                    _actionLists = new DesignerActionListCollection();
                    _actionLists.Add(new MyButtonActionList(this.Component));
                }
                return _actionLists;
            }
        }

        public class MyButtonActionList : System.ComponentModel.Design.DesignerActionList
        {
            MyButton2 _myButton2;

            private DesignerActionUIService _designerActionUISvc = null;

            //The constructor associates the control with the smart tag list.
            public MyButtonActionList(IComponent component)
                : base(component)
            {
                _myButton2 = component as MyButton2;

                // Cache a reference to DesignerActionUIService, 
                // so the DesigneractionList can be refreshed.
                _designerActionUISvc = GetService(typeof(DesignerActionUIService))
            as DesignerActionUIService;
            }

            public override DesignerActionItemCollection GetSortedActionItems()
            {
                DesignerActionItemCollection items = new DesignerActionItemCollection();
                items.Add(new DesignerActionMethodItem(
                    this,
                    "ShowMessageBox",
                    "Show MessageBox",
                    "Trigger",
                    "",
                    true));
                items.Add(new DesignerActionMethodItem(
                    this,
                    "SetBackgroundRed",
                    "Red Background",
                    "BackgroundColor",
                    "",
                    true));
                items.Add(new DesignerActionMethodItem(
                    this,
                    "SetBackgroundWhite",
                    "White Background",
                    "BackgroundColor",
                    "",
                    true));
                items.Add(new DesignerActionMethodItem(
                    this,
                    "SetBackgroundBlue",
                    "Blue Background",
                    "BackgroundColor",
                    "",
                    true));
                return items;
            }

            public void ShowMessageBox()
            {
                System.Windows.Forms.MessageBox.Show("Hello World from .NET Framework 4.6.2 Windows Forms", "Show MessageBox"); ;
            }

            public void SetBackgroundRed()
            {
                _myButton2.BackColor = System.Drawing.Color.Red;
            }

            public void SetBackgroundWhite()
            {
                _myButton2.BackColor = System.Drawing.Color.White;
            }

            public void SetBackgroundBlue()
            {

                _myButton2.BackColor = System.Drawing.Color.Blue;
            }
        }
    }

}
