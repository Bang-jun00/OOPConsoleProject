using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.GameObjPotal
{
    public class Eidos : GameObject
    {
        private string scene;

        public Eidos(string scene, char symbol, Vector2 position) : base(ConsoleColor.Green, symbol, position)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
