using Android.App;
using Android.Widget;
using Android.OS;
using System.Diagnostics;


namespace ConnectFour
{   
    [Activity(Label = "ConnectFour", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        GameBoard game;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Diagnostics.Debug.WriteLine("derp");
            game = new GameBoard(10,7);

            // This is for testing only !!!!!!!!!!!<<<<>>>><<<>>
            int[] numbers = new int[2] { 1, 8 };
            // this is additional testing
            game.gameLogic.ConditionChecker(numbers, game.positions);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

