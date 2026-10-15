using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvores
{
    /* <T> Este TEZÃO REPRESENTA GENERIC
    permite definir o tipo específio
    Para TreeNode quando ele for declarado/instanciado*/
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public int GetHeight ()
        {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}
