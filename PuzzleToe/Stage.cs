using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleToe
{
    internal class Stage
    {

        private List<int[]> stages = new List<int[]>();
        private List<Image> images = new List<Image>(); 
        private Dictionary<int[,], Button> arrBtnPair = new Dictionary<int[,], Button>();


        public List<Image> Images
        {
            get { return images; }
        }

        public List<int[]> Stages
        {
            get { return stages; }
        }


        public Stage()
        {
            initializeStages();
            initializeImages();
        }

        private void initializeImages()
        {
            images.Add(Properties.Resources.stage1);
            images.Add(Properties.Resources.stage2);
            images.Add(Properties.Resources.stage3);
            images.Add(Properties.Resources.stage4);
            images.Add(Properties.Resources.stage6_11);
            images.Add(Properties.Resources.stage6_11);
            images.Add(Properties.Resources.stage6_11);
            images.Add(Properties.Resources.stage6_11);
            images.Add(Properties.Resources.stage6_11);
            images.Add(Properties.Resources.stage6_11);
            images.Add(Properties.Resources.stage12);
            images.Add(Properties.Resources.stage13);
            images.Add(Properties.Resources.stage14);
            images.Add(Properties.Resources.stage15);
            images.Add(Properties.Resources.stage16);



        }

        private void initializeStages()
        {

            // 1
            stages.Add(new int[16]
            {
                0, 0, 0, 0,
                0, 0, 1, 0,
                0, 1, 1, 0,
                0, 0, 1, 0
            });

            // 2
            stages.Add(new int[16]
            {
                0, 0, 0, 0,
                0, 0, 1, 0,
                0, 1, 0, 1,
                0, 0, 1, 0
            });

            // 3
            stages.Add(new int[16]
            {
                1, 0, 0, 0,
                1, 0, 0, 0,
                0, 1, 1, 0,
                0, 0, 0, 0
            });

            // 4
            stages.Add(new int[16]
            {
                0, 0, 1, 0,
                0, 0, 0, 1,
                0, 0, 1, 0,
                0, 0, 0, 1
            });

           
            // 6 -
            stages.Add(new int[16] {
                0, 0, 0, 0,
                0, 0, 0, 0,
                1, 0, 0, 0,
                1, 1, 1, 0
            });

            // 7
            stages.Add(new int[16] {
                0, 0, 0, 0,
                1, 0, 0, 0,
                1, 1, 1, 0,
                0, 0, 0, 0
            });

            // 8
            stages.Add(new int[16] {
                1, 0, 0, 0,
                1, 1, 1, 0,
                0, 0, 0, 0,
                0, 0, 0, 0
            });

            // 9
            stages.Add(new int[16] {
                0, 1, 0, 0,
                0, 1, 1, 1,
                0, 0, 0, 0,
                0, 0, 0, 0
            });

            // 10
            stages.Add(new int[16] {
                0, 0, 0, 0,
                0, 1, 0, 0,
                0, 1, 1, 1,
                0, 0, 0, 0
            });
            // 11 -
            stages.Add(new int[16] {
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 1, 0, 0,
                0, 1, 1, 1
            });

            //12
            stages.Add(new int[16] {
                0, 1, 0, 0,
                0, 1, 1, 0,
                0, 1, 0, 0,
                0, 0, 0, 0
            });

            //13
            stages.Add(new int[16] {
                0, 0, 0, 1,
                0, 0, 1, 1,
                0, 0, 0, 1,
                0, 0, 0, 0
            });
            
            //14
            stages.Add(new int[16] {
                0, 0, 0, 0,
                0, 0, 0, 1,
                0, 0, 0, 1,
                0, 1, 1, 0
            });
            

            //15
            stages.Add(new int[16] {
                0, 1, 1, 0,
                0, 0, 1, 0,
                0, 1, 0, 0,
                0, 0, 0, 0
            });
            
            //16
            stages.Add(new int[16] {
                1, 0, 0, 0,
                1, 0, 0, 0,
                1, 1, 0, 0,
                0, 0, 0, 0
            });

        }


        public int[] setStage(int random_num)
        {
            return stages[random_num];
        }
    }
}
