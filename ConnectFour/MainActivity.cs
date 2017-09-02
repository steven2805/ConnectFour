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

            // this is additional testing
           
            game.playmove(0);
			game.playmove(1);
            game.playmove(1);
            game.playmove(2);
            game.playmove(3);
            game.gameLogic.ConditionChecker(game.positions);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            //TextView textview = FindViewById<TextView>(Resource.Id.two);
            TableLayout tablelayout = FindViewById<TableLayout>(Resource.Id.tableLayout);

            int counter = 0;
            while(counter <= game.GetHeightGrid() - 1 ){
                TableRow tbr = new TableRow(this);
                tbr.Id = counter;
                tablelayout.AddView(tbr);
                counter++;
                int widthCounter = 0;
                while(widthCounter <= game.GetWidthGrid() - 1){
                    Button btn = new Button(this);
                    btn.Id = counter + 100;
                    tbr.AddView(btn);
                    widthCounter++;
                }
			}






			button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

