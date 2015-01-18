using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace liste {
    public class List {
        private class ListElement {
            public string data = null;
            public ListElement next = null;
        }
        private ListElement mHead;
        public List() {
            /// constructor 
        }
        
        public List(List other) {
            /// zweitletztes
            /// create a copy of 'other' 
        }
        public void pushFront(string s) {
            if (empty()) {
                
                var ele = new ListElement();
                
                ele.data = s;
                ele.next = null;
                
                mHead = ele;
                
                return;
            }
            /// insert element at the front of list 
        }
        
        public void pushBack(string s) {
            var ele = new ListElement();
            
            ele.data = s;
            ele.next = null;
            if (empty()) {
                mHead = ele;
            } else {
                var tmp = mHead;
                
                while (tmp.next != null) {
                    tmp = tmp.next;
                }
                tmp.next = ele;
            }
        }
        
        public void pushAt(int index, string s) {
            // vorvorletzte 
            /// insert 's' after 'index' 
        }
        public int size() {
             int counter = 0;
             var tmp = mHead;
             
             while (tmp != null) {
                 counter++;
                 tmp = tmp.next;
            }
            
            return counter;
        }
        
        public bool empty() {
            return mHead == null;
        }
        public string takeFront() {
            
            var ret = mHead.data;
            mHead = mHead.next;
            
            return ret;
        }
        public string takeBack() {
            var tmp = mHead;
            var next = tmp.next;
            
            while (next != null) {
                tmp = tmp.next;
                next = tmp.next;
            }
            string data = next.data;
            tmp.next = null;
            return data;
            /// remove last element of the list and return it 
        }
        public string take(int index) {
            return "";
            /// letzte 
            /// remove element at 'index' and return it 
        }
        public bool contains(string s) {
            var tmp = mHead;
            while (tmp != null) {
                 if (tmp.data == s) {
                     return true;
                 }
                 
                 tmp = tmp.next;
            }
            
            return false;
        }
        public void clear() {
            mHead = null;
        }
        public string front() {
            if (!empty()) {
                return mHead.data;
            } else {
                 throw new Exception();   
            }
        }
        public string back() {
            if (!empty()) {
                var tmp = mHead;
                while (tmp.next != null) {
                    tmp = tmp.next;
                }
                return tmp.data;
            } else {
                throw new Exception();
            }
        }
            /// get last element of the list
        public string at(int index) {
            int counter = 0;
            
            if (index < 0)
                throw new Exception();
                
            
            if (index < size()) {
                var tmp = mHead;
                
                while (counter < index) {
                    tmp = tmp.next;
                    counter++;
                }
                return tmp.data;
            } else {
                throw new Exception();
            }
        }
        public void printAll() {
            var tmp = mHead;
            
            while (tmp != null) {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }
    }
}
