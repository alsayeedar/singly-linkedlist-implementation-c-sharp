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
            public void remove(int ndata){
                Node node = this.head;
                while(node != null){
                    if(node.data == ndata){
                        if(node == this.head){
                            this.head = node.next;
                            this.size--;
                        }
                        if(node == this.tail){
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
                        }
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
        }

    }
}
