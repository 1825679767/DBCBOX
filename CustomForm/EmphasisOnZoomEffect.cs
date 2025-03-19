using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using DSkin.Animations;

namespace BoxDBC
{
    /// <summary>
    /// 强调缩放
    /// </summary>
    public class EmphasisOnZoomEffect : IEffects
    {
        public EmphasisOnZoomEffect()
        {
        }
        public EmphasisOnZoomEffect(double Zoon)
        {
            ZoonXishu = Zoon;
        }
        public double ZoonXishu = 1.2;

        public string Name
        {
            get { return "强调缩放特效"; }
        }

        readonly int AtTotalframes = 50;

        Bitmap AtBitmap = null;

        public bool CanDesc
        {
            get { return true; }
        }

        bool _IsAsc = true;

        public bool IsAsc
        {
            get { return _IsAsc; }
            set { _IsAsc = value; }
        }

        bool _IsFinal = true;

        public bool IsFinal
        {
            get { return _IsFinal; }
        }

        public void Reset()
        {
            AtZoon1 = 0;
            AtZoon2 = 0;
        }
        Bitmap _Original;

        public Bitmap Original
        {
            get { return _Original; }
            set { _Original = value; }
        }
        int AtZoon1 = 20;
        int AtZoon2 = 0;

        public Bitmap DoEffect(out Point Offset)
        {
            Offset = new Point();
            if (_Original != null)
            {
                if (AtBitmap == null || AtBitmap.Size != new Size((int)(_Original.Width * ZoonXishu), (int)(_Original.Height * ZoonXishu)))
                {
                    //缓存位图
                    AtBitmap = new Bitmap((int)(_Original.Width * ZoonXishu), (int)(_Original.Height * ZoonXishu));
                }
                Offset = new Point(_Original.Width / 2 - AtBitmap.Width / 2, _Original.Height / 2 - AtBitmap.Height / 2);
                float Percent;
                if (_IsAsc)
                {
                    Percent = (float)(1.0 * (AtZoon1 - AtZoon2) / (AtTotalframes - 1));
                }
                else
                {
                    Percent = 1.0f - (float)(1.0 * (AtZoon1 - AtZoon2) / (AtTotalframes - 1));
                }
                using (Graphics Gr = Graphics.FromImage(AtBitmap))
                {
                    Gr.Clear(Color.Transparent);
                    Size AtSize = new Size(_Original.Size.Width, _Original.Size.Height);
                    Size ChangedSize = new Size((int)(1.0 * AtSize.Width * Percent), (int)(1.0 * AtSize.Height * Percent));
                    RectangleF Rect = new RectangleF((AtBitmap.Width - ChangedSize.Width) * 1.0f / 2, (AtBitmap.Height - ChangedSize.Height) * 1.0f / 2, ChangedSize.Width, ChangedSize.Height);
                    Gr.DrawImage(_Original, Rect);
                }

                if (_IsAsc)
                {
                    if (AtZoon1 < AtTotalframes * ZoonXishu)
                    {
                        AtZoon1 += (int)((AtTotalframes * ZoonXishu + 5 - AtZoon1) / 5);
                        _IsFinal = false;
                    }
                    else
                    {
                        if (AtZoon2 < AtZoon1 - AtTotalframes)
                        {
                            AtZoon2 += (AtZoon1 - AtTotalframes + 10) / 10;
                            _IsFinal = false;
                        }
                        else
                        {
                            _IsFinal = true;
                        }
                    }
                }
                else
                {
                    if (AtZoon2 < AtTotalframes * ZoonXishu - AtTotalframes)
                    {
                        AtZoon2 += (int)(AtTotalframes * ZoonXishu - AtTotalframes + 13) / 13;
                        _IsFinal = false;
                    }
                    else
                    {
                        if (AtZoon1 < (AtTotalframes + AtZoon2))
                        {
                            AtZoon1 += (AtTotalframes + AtZoon2 + 10) / 10;
                            _IsFinal = false;
                        }
                        else
                        {
                            _IsFinal = true;
                        }
                    }
                }


            }


            return AtBitmap;
        }

        public ImageAttributes GetAlphaImgAttr(int Opcity)
        {
            if (Opcity < 0 || Opcity > 100)
            {
                throw new ArgumentOutOfRangeException("opcity 值为 0~100");
            }
            //颜色矩阵
            float[][] MatrixItems =
            {
                new float[]{1,0,0,0,0},
                new float[]{0,1,0,0,0},
                new float[]{0,0,1,0,0},
                new float[]{0,0,0,(float)Opcity / 100,0},
                new float[]{0,0,0,0,1}
            };
            ColorMatrix CMatrix = new ColorMatrix(MatrixItems);
            ImageAttributes ImageAtt = new ImageAttributes();
            ImageAtt.SetColorMatrix(CMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            return ImageAtt;
        }
        public void Dispose()
        {
            if (AtBitmap != null)
            {
                AtBitmap.Dispose();
                AtBitmap = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
