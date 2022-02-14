#pragma warning disable // this line used to hide warnings
using System;
namespace DataStructure{
    public class Program{

        public class Node{
            public int data;
            public Node next;

            public Node(int data){
                this.data = data;
                this.next = null;
            }
        }
        public class LinkedList{
            public Node head = null;
            public Node tail = null;
            public int size = 0;
            
            // add item function
            public void add(int data){
                Node node = new Node(data);
                this.size++;
                if(this.tail == null){
                    this.head = node;
                    this.tail = node;
                }else{
                    this.tail.next = node;
                    this.tail = node;
                }
            }
            
            // remove item function
            public void remove(int node_data){
                if(this.size > 1){
                    Node node = this.head;
                    Node nprev = null;
                    while(node != null){
                        if(node.data == node_data){
                            if(node == this.head){
                                this.head = node.next;
                                this.size--;
                                break;
                            }else if(node == this.tail){
                                int i = 1;
                                Node node2 = this.head;
                                Node prev = null;
                                while(i < this.size){
                                    prev = node2;
                                    i++;
                                    node2 = node2.next;
                                }
                                this.tail = prev;
                                this.tail.next = null;
                                this.size--;
                                break;
                            }else{
                                nprev.next = node.next;
                                this.size--;
                                break;
                            }
                        }
                        nprev = node;
                        node = node.next;
                    }
                }
            }
            
            // update item function
            public void update(int node_data, int new_node_data){
                Node node = this.head;
                while(node != null){
                    if(node.data == node_data){
                        node.data = new_node_data;
                        break;
                    }
                    node = node.next;
                }
            }
            
            public int? getHead(){
                if(this.head != null){
                    return this.head.data;
                }
                return null;
            }
            public int? getTail(){
                if(this.tail != null){
                    return this.tail.data;
                }
                return null;
            }
            public int getSize(){
                return this.size;
            }
            public void printList(){
                Node node = this.head;
                string list = "[";
                while(node != null){
                    list += node.data;
                    node = node.next;
                    if(node != null){
                        list += ", ";
                    }
                }
                list += "]";
                Console.WriteLine(list);
            }
        }
        public static void Main(string[] args){
            LinkedList mylinkedlist = new LinkedList();
            mylinkedlist.add(3);
            mylinkedlist.add(4);
            mylinkedlist.add(5);
            mylinkedlist.add(9);
            mylinkedlist.add(7);
            mylinkedlist.add(15);
            mylinkedlist.printList();
            mylinkedlist.remove(3);
            mylinkedlist.printList();
            mylinkedlist.remove(9);
            mylinkedlist.printList();
            mylinkedlist.remove(15);
            mylinkedlist.printList();
            mylinkedlist.update(7, 8);
            mylinkedlist.printList();
            /* Output:
            [3, 4, 5, 9, 7, 15]
            [4, 5, 9, 7, 15]
            [4, 5, 7, 15]
            [4, 5, 7]
            [4, 5, 8]
            */
        }

    }
}
