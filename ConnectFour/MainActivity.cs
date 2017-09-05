using Android.App;
using Android.Widget;
using Android.OS;
using System.Diagnostics;


namespace ConnectFour
{
    [Activity(Label = "ConnectFour", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        GameBoard game;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Diagnostics.Debug.WriteLine("derp");
            game = new GameBoard(10, 10);

			// This is for testing only !!!!!!!!!!!<<<<>>>><<<>>

			// this is additional testing
			game.playmove(5,2);
			game.playmove(5,2);
			game.playmove(5,2);
            game.playmove(5,2);
            game.playmove(5,2);
            game.playmove(5,1);
			game.playmove(6,2);
			game.playmove(6,2);
            game.playmove(6,2);
			game.playmove(6,2);
			game.playmove(6,1);
			game.playmove(7,2);
			game.playmove(7,2);
			game.playmove(7,2);
			game.playmove(7,1);
			game.playmove(8,2);
            game.playmove(8,2);
            game.playmove(8,1);
          
			game.gameLogic.ConditionChecker(game.positions);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            //TextView textview = FindViewById<TextView>(Resource.Id.two);
            TableLayout tablelayout = FindViewById<TableLayout>(Resource.Id.tableLayout);




            int counter = game.GetHeightGrid() - 1;
            while (counter >= 0)
            {
                TableRow tbr = new TableRow(this);
                tbr.Id = counter;
                tablelayout.AddView(tbr);

                int widthCounter = 0;
                while (widthCounter <= game.GetWidthGrid() - 1)
                {
                    Button btn = new Button(this);
                    string formatter = counter.ToString() + widthCounter.ToString();
                    btn.Id = widthCounter;
                    btn.Text = game.positions[counter][widthCounter].ToString();
                    tbr.AddView(btn);
                    widthCounter++;
                    System.Diagnostics.Debug.WriteLine(btn.Id);

                }
                counter--;
            }

           






            button.Click += delegate { System.Diagnostics.Debug.WriteLine("derp"); };
        }

    }
}

