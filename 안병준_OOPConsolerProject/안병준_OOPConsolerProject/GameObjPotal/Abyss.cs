using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.GameObjPotal
{
    public class Abyss : GameObject
    {
        private string scene;

        public Abyss(string scene, char symbol, Vector2 position) : base(ConsoleColor.DarkMagenta, symbol, position)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
