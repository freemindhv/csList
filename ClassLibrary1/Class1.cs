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
            /// must be reworked, iterating over the 'other' list 100000000000000000 times to copy it is ugly as fuck
            var ele = new ListElement();
            ele.data = null;
            ele.next = null;
            ListElement prev = null;
            var cur = mHead;
            var size = other.size();

            for (var i = 0; i < 10; i++) {
                if (prev != null) {
                    prev.next = cur;
                }
                cur.data = other.at(i);
                prev = cur;
            }
        }
        public void pushFront(string s) {
            if (empty()) {
                
                var ele = new ListElement();
                
                ele.data = s;
                ele.next = null;
                
                mHead = ele;
                
                return;
            }
        }
        
        public void pushBack(string s) {
            var ele = new ListElement();
            
            ele.data = s;
            ele.next = null;
            if (empty()) {
                mHead = ele;
            } else {
                var cur = mHead;
                
                while (cur.next != null) {
                    cur = cur.next;
                }
                cur.next = ele;
            }
        }
        
        public void pushAt(int index, string s) {
            var counter = 0;
            var cur = mHead;
            var ele = new ListElement();
            ele.data = s;
            ele.next = null;

            if (empty()) {
                throw new Exception();
            } else if (index > size()) {
                throw new Exception();
            } else {
                while (counter <= index) {
                    if (counter == index) {
                        ele.next = cur.next;
                        cur.next = ele;
                    } else {
                    cur = cur.next;
                    counter++;
                    }
                }
            }
        }
        public int size() {
             int counter = 0;
             var cur = mHead;
             
             while (cur != null) {
                 counter++;
                 cur = cur.next;
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
            var cur = mHead;
            var next = cur.next;
            
            while (next != null) {
                cur = cur.next;
                next = cur.next;
            }
            string data = next.data;
            cur.next = null;
            return data;
        }
        public string take(int index) {
            if (empty()) {
                throw new Exception();
            } else if (index > size()) {
                throw new Exception();
            } else {
                var cur = mHead;
                var counter = 0;
                ListElement prev = null;
                while (counter < index) {
                    prev = cur;
                    cur = cur.next;
                    counter++;
                }
                prev.next = cur.next;
            }
        }
        public bool contains(string s) {
            var cur = mHead;
            while (cur != null) {
                 if (cur.data == s) {
                     return true;
                 }
                 
                 cur = cur.next;
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
                var cur = mHead;
                while (cur.next != null) {
                    cur = cur.next;
                }
                return cur.data;
            } else {
                throw new Exception();
            }
        }
        public string at(int index) {
            int counter = 0;
            
            if (index < 0)
                throw new Exception();
                
            
            if (index < size()) {
                var cur = mHead;
                
                while (counter < index) {
                    cur = cur.next;
                    counter++;
                }
                return cur.data;
            } else {
                throw new Exception();
            }
        }
        public void printAll() {
            var cur = mHead;
            
            while (cur != null) {
                Console.WriteLine(cur.data);
                cur = cur.next;
            }
        }
    }
}
