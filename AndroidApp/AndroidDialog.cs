using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PCLProject;

namespace AndroidApp
{
    public class AndroidDialog : IDialog
    {
        Context context;

        public AndroidDialog(Context context)
        {
            this.context = context;
        }

        public void Show(string message)
        {
            var builder = new AlertDialog.Builder(context);
            var alert = builder.Create();
            alert.SetTitle("Resultado de la verificación");
            alert.SetIcon(Resource.Drawable.Icon);
            alert.SetMessage(message);
            alert.SetButton("Ok", (s, ev) => { });
            alert.Show();
        }
    }
}