using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dyClawler.Repository.Model
{
    public class MovieType
    {
        /// <summary>
        /// 热门
        /// </summary>
        public static int Hot { get; } = 1;
        /// <summary>
        /// 最新
        /// </summary>
        public static int Latest { get; } = 2;

        /// <summary>
        /// Dy2018恐怖类型
        /// </summary>
        public static int Dy2018Horror { get; } = 8;

        /// <summary>
        ///  Dy2018科幻类型
        /// </summary>
        public static int Dy2018ScienceFiction { get; } = 4;

        /// <summary>
        ///  Dy2018必看
        /// </summary>
        public static int Dy2018Bikan { get; } = 100;

    }
}
