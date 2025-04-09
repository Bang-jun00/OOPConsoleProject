using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 안병준_OOPConsolerProject.GameObjPotal
{
    public class Castle : GameObject
    {
        private string scene;

        public Castle(string scene, char symbol, Vector2 position) : base(ConsoleColor.Red, symbol, position)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            Game.ChangeScene(scene);
        }
    }
}
