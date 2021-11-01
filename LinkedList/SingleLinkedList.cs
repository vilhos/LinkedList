using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public T _data;
        public Node<T> next;
        public Node(T data)
        {
            _data = data;
            next = null;
        }
    }
    public class SingleLinkedList<T> 
    {
        public Node<T> head;
        public void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void InsertLast(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node<T> lastNode = GetLastNode();
            lastNode.next = new_node;
        }

        public Node<T> GetLastNode()
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void InsertAfter(Node<T> prev_node, T new_data)
        {
            if (prev_node == null)
            {
                throw new NullReferenceException("Previous node Cannot be null");
            }
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        public void DeleteNodebyKey(T key)
        {
            Node<T> temp = head;
            Node<T> prev = null;
            if (temp != null && temp._data.Equals(key))
            {
                head = temp.next;
                return;
            }
            while (temp != null && !temp._data.Equals(key))
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
        public void ReverseLinkedList()
        {
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }
    }
}
