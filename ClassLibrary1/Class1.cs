using System;
using System.Diagnostics;
using liste;

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
            var tmp = mHead;

            for (var x = other.mHead; x != null; x = x.next) {
                var ele = new ListElement();
                ele.data = x.data;
                if (mHead == null) {
                    mHead = ele;
                    tmp = mHead;
                }
                else {
                    tmp.next = ele;
                    tmp = tmp.next;
                }
            }
        }
        public void pushFront(string s) {
            var ele = new ListElement();

            ele.data = s;
            ele.next = mHead;

            mHead = ele;

            return;
        }

        public void pushBack(string s) {
            var ele = new ListElement();

            ele.data = s;
            ele.next = null;
            if (empty()) {
                mHead = ele;
            }
            else {
                var cur = mHead;

                while (cur.next != null) {
                    cur = cur.next;
                }
                cur.next = ele;
            }
        }

        public void pushAt(int index, string s) {
            var cur = mHead;
            var ele = new ListElement();
            ele.data = s;
            ele.next = null;

            if (index == 0) {
                ele.next = mHead;
                mHead = ele;
                return;
            }

            if (empty())
                throw new Exception();

            if (index < 0)
                throw new Exception();

            for (int i = 0; i < index - 1; i++) {
                cur = cur.next;
            }

            if (cur == null)
                throw new Exception("Invalid Index");

            ele.next = cur.next;
            cur.next = ele;
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
            ListElement prev = null;

            while (cur.next != null) {
                prev = cur;
                cur = cur.next;
            }
            string data = cur.data;
            prev.next = null;
            return data;
        }
        public string takeAt(int index) {
            if (empty()) {
                throw new Exception();
            }
            if (index == 0) {
                var t = mHead.data;
                mHead = mHead.next;
                return t;
            }
            var cur = mHead;

            for (int i = 0; i < index - 1 && cur != null; i++)
                cur = cur.next;

            if (cur == null || cur.next == null)
                throw new Exception("Invalid Index");

            var ret = cur.next.data;
            cur.next = cur.next.next;
            return ret;
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
            }
            else {
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
            }
            else {
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
            }
            else {
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