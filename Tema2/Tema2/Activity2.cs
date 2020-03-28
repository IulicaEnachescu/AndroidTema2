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
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        Person person, person2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            base.SetContentView(Resource.Layout.Activity2);
            TextView textView1 = FindViewById<TextView>(Resource.Id.text1);
  
            //textView1
            textView1.Text = "Hello Android TextView";
            person = new Person();
            person.NamePers = "Ion";
            person.SurnamePers = "Popescu";
            textView1.Append("\n" + person.NamePers + "\t" + person.SurnamePers);
            textView1.Text += "\n" + person.NamePers + "\t" + person.SurnamePers;
            textView1.Text += "\n" + GetString(Resource.String.denumire_1);
            person2 = new Person();
            person2.NamePers = "Ion";
            person2.SurnamePers = "Popescu";
            textView1.Append("\n" + person2.NamePers + "\t" + person2.SurnamePers);
            textView1.Text += "\n" + person2.NamePers + "\t" + person2.SurnamePers;
            textView1.Text += "\n" + GetString(Resource.String.denumire_1);
            // Create your application here


        }

        
    }
}


/*
 *  <string name="action_settings">Settings</string>
   <string name="app_name">ADM_2_2018</string>[Activity(Label = "Activity2")]
public class Activity2 : Activity
{
    Person person;
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        base.SetContentView(Resource.Layout.Activity2);
        TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
        textView1.Text = "Hello Android TextView";
        // Create your application here
        person = new Person();
        person.NamePers = "Ion";
        3
    person.SurnamePers = "Popescu";
        // de studiat individual metoda append
        // textView1.Append("\n" + person.NamePers +"\t"+person.SurnamePers);
        textView1.Text += "\n" + person.NamePers + "\t" + person.SurnamePers;
        textView1.Text += "\n" + GetString(Resource.String.denumire_1);
    }
}
}*/
