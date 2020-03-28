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

namespace Tema2
{
    public class Person
    {
        private string namePers;
        private string surnamePers;
        public string NamePers
        {
            get => namePers;
            set => namePers = value;
        }
        public string SurnamePers
        {
            get => surnamePers;
            set => surnamePers = value;
        }
    }
}