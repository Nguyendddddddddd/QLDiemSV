using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI.UI
{
    public class LoadData
    {
        public static void loadCombobox<T>(Guna2ComboBox cbo,string displayMember, string valueMember,List<T> data)
        {
            cbo.DataSource = data;
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }
    }
}
