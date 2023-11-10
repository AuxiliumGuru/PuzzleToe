using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickMe
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
            images.Add(Image.FromFile("C:\\Users\\khest\\Documents\\C#\\Projects\\FindMe\\ClickMe\\ClickMe\\stage1.png"));
            images.Add(Image.FromFile("C:\\Users\\khest\\Documents\\C#\\Projects\\FindMe\\ClickMe\\ClickMe\\stage2.png"));
            images.Add(Image.FromFile("C:\\Users\\khest\\Documents\\C#\\Projects\\FindMe\\ClickMe\\ClickMe\\stage3.png"));
            images.Add(Image.FromFile("C:\\Users\\khest\\Documents\\C#\\Projects\\FindMe\\ClickMe\\ClickMe\\stage4.png"));


        }

        private void initializeStages()
        {
            stages.Add(new int[16]
            {
                0, 0, 0, 0,
                0, 0, 1, 0,
                0, 1, 1, 0,
                0, 0, 1, 0
            });

            stages.Add(new int[16]
            {
                0, 0, 0, 0,
                0, 0, 1, 0,
                0, 1, 0, 1,
                0, 0, 1, 0
            });

            stages.Add(new int[16]
            {
                1, 0, 0, 0,
                1, 0, 0, 0,
                0, 1, 1, 0,
                0, 0, 0, 0
            });

            stages.Add(new int[16]
            {
                0, 0, 1, 0,
                0, 0, 0, 1,
                0, 0, 1, 0,
                0, 0, 0, 1
            });

            //stages.Add(new int[16]
            //{
            //    0, 0, 0, 0,
            //    0, 0, 1, 0,
            //    0, 1, 1, 0,
            //    0, 0, 1, 0
            //});

            //stages.Add(new int[16]
            //{
            //    0, 0, 0, 0,
            //    0, 0, 1, 0,
            //    0, 1, 1, 0,
            //    0, 0, 1, 0
            //});
        }


        public int[] setStage(int random_num)
        {
            return stages[random_num];
        }
    }
}
