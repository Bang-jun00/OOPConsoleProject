using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 안병준_OOPConsolerProject.Scenes;

namespace 안병준_OOPConsolerProject
{
    public static class Game
    {
        //게임 진행시 필요한 정보.
        
        //장면
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        //플레이어 정보
        

        public static Player player;
        public static Player Player { get { return player; } }
        
        public static PlayerInform playerInform;

        
       

        

        private static bool gameOver;

        
       
        public static void Run()
        {
            Start();
            
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
                

            End();
        }
        

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

       

        /// <summary>
        /// 게임 시작 작업 진행
        /// </summary>
        
        private static void Start()
        {
            //커서 깜빡이는 걸 숨기는 기능
            Console.CursorVisible = false; 
            
            //게임 설정
            gameOver = false;

            //플레이어 설정
            player = new Player();
            
            //씬 설정
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title",new TitleScene());
            sceneDic.Add("Prologue", new PrologueScene());
            sceneDic.Add("Character", new CreatCharacterScene());
            sceneDic.Add("Field", new FieldScene());
            sceneDic.Add("Eidos", new SanctuaryEidos());
            sceneDic.Add("Light", new SanctuaryOfLight());
            sceneDic.Add("chaos", new BorderOfChaos());
            sceneDic.Add("Abyss", new AbyssofTruth());
            sceneDic.Add("Castle",new TheDevilKingCastle());
            sceneDic.Add("Ending1",new EndingScene1());
            sceneDic.Add("Ending2", new EndingScene2());
            
            
            
            //초기 씬을 타이틀로 설정
            curScene = sceneDic["Title"];

            

        }

        /// <summary>
        /// 게임의 마무리 진행 
        /// </summary>
        private static void End()
        {
            gameOver = true;
        }
    }

}
