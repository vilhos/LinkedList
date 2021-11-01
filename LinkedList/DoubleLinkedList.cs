using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DNode<T>
    {
        internal T _data;
        internal DNode<T> prev;
        internal DNode<T> next;
        public DNode(T data)
        {
            _data = data;
            prev = null;
            next = null;
        }
    }
    class DoubleLinkedList<T>
    {
        public DNode<T> head;
        public void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = head;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }
        public void InsertLast(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        public DNode<T> GetLastNode()
        {
            DNode<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal void InsertAfter(DNode<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                throw new NullReferenceException("Previous node Cannot be null");
            }
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
        public void DeleteNodebyKey(T key)
        {
            DNode<T> temp = head;
            if (temp != null && temp._data.Equals(key))
            {
                head = temp.next;
                head.prev = null;
                return;
            }
            while (temp != null && !temp._data.Equals(key))
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

        public void ReverseLinkedList()
        {
            DNode<T> current = head;
            DNode<T> temp = null;
            while (current != null)
            {
                temp = current.prev;
                current.prev = current.next;
                current.next = temp;
                current = current.prev;
            }

            if (temp != null)
            {
                head = temp.prev;
            }
        }
    }
}
