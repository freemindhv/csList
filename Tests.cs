using System;
using System.Diagnostics;
using liste;

class ListTest {
    static void test_pushBack() {
        var myList = new List();

        myList.pushBack("A");
        myList.pushBack("B");
        myList.pushBack("C");

        Debug.Assert(myList.at(0) == myList.front() && myList.at(0) == "A");
        Debug.Assert(myList.at(1) == "B");
        Debug.Assert(myList.at(2) == myList.back() && myList.at(2) == "C");
        Debug.Assert(myList.size() == 3 && !myList.empty());
    }

    static void test_pushFront() {
        var myList = new List();

        myList.pushFront("A");
        myList.pushFront("B");
        myList.pushFront("C");

        Debug.Assert(myList.at(2) == myList.back() && myList.at(2) == "A");
        Debug.Assert(myList.at(1) == "B");
        Debug.Assert(myList.at(0) == myList.front() && myList.at(0) == "C");
        Debug.Assert(myList.size() == 3 && !myList.empty());
    }

    static void test_contains() {
        var myList = new List();
        int loops = 1000;

        for (int i = 0; i < loops / 2; ++i) {
            myList.pushFront("A");
        }

        myList.pushFront("Z");

        for (int i = loops / 2; i < loops; ++i) {
            myList.pushFront("A");
        }

        Debug.Assert(myList.contains("Z") && myList.at(loops / 2) == "Z");
    }

    static void test_clear() {
        var myList = new List();

        int loops = 100;

        for (int i = 0; i < loops; ++i) {
            myList.pushFront("A");
        }

        myList.clear();

        Debug.Assert(myList.empty() && myList.size() == 0);
    }

    static void test_takeBack() {
        var myList = new List();
        int loops = 100;
        for (int i = 0; i < loops; ++i) {
            myList.pushFront("A");
        }
        myList.pushBack("Z");
        Debug.Assert(myList.takeBack() == "Z");
        Debug.Assert(!myList.contains("Z"));
        Debug.Assert(myList.back() == "A");
    }
    static void test_takeFront() {
        var myList = new List();
        int loops = 100;
        for (int i = 0; i < loops; ++i) {
            myList.pushFront("A");
        }
        myList.pushFront("Z");
        Debug.Assert(myList.takeFront() == "Z");
        Debug.Assert(!myList.contains("Z"));
        Debug.Assert(myList.front() == "A");
    }
    static void test_takeAt() {
        var myList = new List();
        var array = new string[] { "0", "1", "2", "3", "4", "5", "6", "7" };
        foreach (string s in array) {
            myList.pushBack(s);
        }
        Debug.Assert(myList.takeAt(5) == "5");
        Debug.Assert(myList.takeAt(0) == "0");
        Debug.Assert(myList.takeAt(5) == "7");
    }
    static void test_copyConstructor() {
        var myList = new List();
        myList.pushFront("1");
        myList.pushFront("2");
        myList.pushFront("3");
        myList.pushFront("4");
        myList.pushFront("5");
        myList.pushFront("6");
        myList.pushFront("7");
        myList.pushFront("8");
        myList.pushFront("9");
        myList.pushFront("10");
        myList.pushFront("11");
        myList.pushFront("12");
        var myListCopy = new List(myList);
        var size = myList.size();
        Debug.Assert(size == myListCopy.size());
        while (size-- > 0) {
            Debug.Assert(myList.at(size) == myListCopy.at(size));
        }

        myList.pushBack("13");

        Debug.Assert(!myListCopy.contains("13"));
    }
    static void test_insertAt() {
        var myList = new List();

        myList.pushAt(0, "A");
        myList.pushAt(0, "B");
        myList.pushAt(1, "C");
        myList.pushAt(1, "D");

        myList.pushAt(myList.size(), "E");

        var test = new string[] { "B", "D", "C", "A", "E" };

        for (int i = 0; i < test.Length; ++i)
            Debug.Assert(myList.at(i) == test[i]);
    }

    static void Main() {
        try {
            test_pushFront();
            test_pushBack();
            test_contains();
            test_clear();
            test_takeBack();
            test_takeFront();
            test_takeAt();
            test_copyConstructor();
            test_insertAt();
            test_at();

            Console.WriteLine("** SUCCESS: all tests were successful");

            Console.ReadKey();
        }
        catch (Exception e) {
            Console.WriteLine("** ERROR: {0}", e);
        }

    }

    private static void test_at() {
        var myList = new List();
        myList.pushFront("1");
        myList.pushBack("2");
        myList.pushBack("3");
        Debug.Assert(myList[1] == "2");
        myList[1] = "test";
        Debug.Assert(myList[1] == "test");
    }
}