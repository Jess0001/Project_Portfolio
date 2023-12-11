using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CanYouSaveSirDewford
{
    //class to set tree data
    public class DeweyTreeNode<T> : IEnumerable<DeweyTreeNode<T>>
    {
        public T Data { get; set; }
        public DeweyTreeNode<T> Parent { get; set; }
        public ICollection<DeweyTreeNode<T>> Children { get; set; }
        public Boolean IsRoot
        {
            get { return Parent == null; }
        }

        public Boolean IsLeaf
        {
            get { return Children.Count == 0; }
        }

        public int Level
        {
            get
            {
                if (this.IsRoot)
                    return 0;
                return Parent.Level + 1;
            }
        }

        public ICollection<DeweyTreeNode<T>> Elements { get; set; }
        public ICollection<DeweyTreeNode<T>> ElementsIndex { get; set; }
        public DeweyTreeNode(T data)
        {
            this.Data = data;
            this.Children = new LinkedList<DeweyTreeNode<T>>();

            this.ElementsIndex = new LinkedList<DeweyTreeNode<T>>();
            this.ElementsIndex.Add(this);
        }

        public DeweyTreeNode<T> AddChild(T child)
        {
            DeweyTreeNode<T> childNode = new DeweyTreeNode<T>(child) { Parent = this };
            this.Children.Add(childNode);

            this.RegisterChildForSearch(childNode);

            return childNode;
        }

        public override string ToString()
        {
            return Data != null ? Data.ToString() : "[data null]";
        }

        public void RegisterChildForSearch(DeweyTreeNode<T> node)
        {
            ElementsIndex.Add(node);
            if (Parent != null)
                Parent.RegisterChildForSearch(node);
        }

        public DeweyTreeNode<T> FindTreeNode(Func<DeweyTreeNode<T>, bool> predicate)
        {
            return this.ElementsIndex.FirstOrDefault(predicate);
        }

        public IEnumerator<DeweyTreeNode<T>> GetEnumerator()
        {
            yield return this;
            foreach (var directChild in this.Children)
            {
                foreach (var anyChild in directChild)
                    yield return anyChild;
            }
        }

        IEnumerator<DeweyTreeNode<T>> IEnumerable<DeweyTreeNode<T>>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
