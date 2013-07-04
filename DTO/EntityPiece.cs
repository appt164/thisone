using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DTO
{
     public class EntityPiece
    {
        [Key]
        public int PieceID
        {
            get;
            set;
        }

        public int PosX
        {
            get;
            set;
        }

        public int PosY
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }

        public int Color
        {
            get;
            set;
        }
    }
}
