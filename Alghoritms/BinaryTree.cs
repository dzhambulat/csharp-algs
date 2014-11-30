using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghoritms.Trees
{
    public interface IBinaryTree<K,T> where K:IComparable
    {
        void Add(K key,T value);
        void RemoveByKey(K key);
        T GetValueByKey(K key);
    }

    class TreeNode<K,T>
    {
        public K key;
        public T value;

        public TreeNode(K key,T value)
        {
            this.key = key;
            this.value = value;
        }

        public bool IsNull
        {
            get;
            set;
        }

        public TreeNode<K, T> LeftSon;
        public TreeNode<K, T> RightSon;
        public TreeNode<K, T> parent;

    }

    class BinaryTree<K,T>:IBinaryTree<K,T> where K:IComparable
    {

        TreeNode<K, T> _root;
        TreeNode<K, T> _nullNode = new TreeNode<K, T>(default(K),default(T));
        public BinaryTree()
        {
            _nullNode.IsNull = true;
            _root = _nullNode;

        }
        public void Add(K key,T value)
        {
            TreeNode<K, T> newNode = new TreeNode<K, T>(key,value);


            if (_root.IsNull)
            {
                _root = newNode;
                _root.LeftSon=new TreeNode<K,T>(default(K),default(T));
                _root.RightSon=new TreeNode<K,T>(default(K),default(T));
                _root.LeftSon.IsNull=_root.RightSon.IsNull=true;

            }
            else
            {
                TreeNode<K, T> tempNode = _root;
                TreeNode<K, T> parentNode = null;
                while(!tempNode.IsNull)
                {
                    parentNode = tempNode;
                    if (key.CompareTo(tempNode.key)>=0)
                        tempNode = tempNode.RightSon;
                    else
                        tempNode = tempNode.LeftSon;


                }

                if (parentNode.LeftSon == tempNode)
                    parentNode.LeftSon = newNode;
                else parentNode.RightSon = newNode;

                newNode.parent = parentNode;
                newNode.LeftSon = tempNode;
                tempNode.parent = newNode;
                newNode.RightSon = new TreeNode<K, T>(default(K), default(T));
                newNode.RightSon.IsNull = true;
                newNode.parent = newNode;
            }
        }

        public void RemoveByKey(K key)
        {

        }
        public T GetValueByKey(K key)
        {
            return default(T);
        }
    }
}
