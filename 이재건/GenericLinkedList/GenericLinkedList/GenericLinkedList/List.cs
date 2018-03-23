using System;
using System.Windows.Forms;

namespace GenericLinkedList
{
    class DList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public static int listLength = 0;

        public DList()
        {
            head = new Node<T>();
            tail = new Node<T>();
            head.next = null;
            tail.prev = null;


        }

        public T InsertNode(T value)
        {
            Node<T> tempNode = new Node<T>();
            try
            {
                if (head.next == null)
                {
                    tempNode.value = value;
                    head.next = tempNode;
                    tempNode.prev = head;
                    tempNode.next = tail;
                    tail.prev = tempNode;
                    listLength++;
                    Console.WriteLine(head.next.value);
                    return value;
                }
            }
            catch (NullReferenceException ex)
            {
                string message = ex.Message + " 에러가 발생하였습니다!! insert 부분을 확인하세요";
                MessageBox.Show(message, "Error!");

            }

            try
            {
                tempNode = head.next;

                while (!(tempNode.next == tail))
                {
                    tempNode = tempNode.next;
                }

                Node<T> insertNode = new Node<T>();
                insertNode.value = value;
                insertNode.prev = tempNode;
                tempNode.next = insertNode;
                insertNode.next = tail;
                tail.prev = insertNode;
                listLength++;
            }
            catch (NullReferenceException ex)
            {
                string message = ex.Message + " 에러가 발생하였습니다!! insert 부분을 확인하세요";
                MessageBox.Show(message, "Error!");
            }

            return value;
        }

        public string PrintHeadToTail()
        {
            if (listLength <= 0)
                return "No List!!! Insert First";

            string temp = "";
            int count = 1;
            Node<T> tempNode = new Node<T>();

            tempNode = head.next;

            if (listLength == 1)
            {
                temp += "현재 Node 위치 :" + count + " 의 값은 : " + tempNode.value + " 입니다\n";
                return temp;

            }

            while (!(tempNode.next == tail))
            {
                temp += "현재 Node 위치 :" + count + " 의 값은 : " + tempNode.value + " 입니다\n";
                tempNode = tempNode.next;
                count++;
            }

            temp += "현재 Node 위치 :" + count + " 의 값은 : " + tempNode.value + " 입니다\n";

            return temp;
        }

        public string InsertAt(int index, T value)
        {
            if (index > listLength + 1 || index <= 0)
            {
                MessageBox.Show("Out Of List Index!! Retry Please");
                return "";
            }
            if (index == 1)
            {
                InsertNode(value);
                return "해당 노드가 비워있으므로 head.next 부분에 값을 채우겠습니다.";
            }

            int count = index;
            string temp = "";
            Node<T> tempNode = new Node<T>();
            tempNode = head.next;

            while (!(count <= 1))
            {
                count--;
                tempNode = tempNode.next;

            }

            Node<T> insertTempNode = new Node<T>();
            insertTempNode.value = value;
            tempNode.next.prev = insertTempNode;
            insertTempNode.next = tempNode.next;
            tempNode.next = insertTempNode;
            insertTempNode.prev = tempNode;
            listLength++;
            temp = "List 의 " + index + "번 째에 " + insertTempNode.value + " 값을 추가하였습니다" +
                "현재 노드의 총 길이는 " + listLength + " 입니다.";
            return temp;

        }

        public string DeleteAt(int index)
        {
            if (index > listLength || index <= 0)
            {
                MessageBox.Show("Out Of List Index!! Retry Please");
                return "";
            }

            else
            {
                int count = index;
                string temp = "";
                Node<T> deleteNode = new Node<T>();
                deleteNode = head.next;

                if (count == 1)
                {

                    listLength--;
                    temp = "List 의 " + index + " 번째에 위치한 " + deleteNode.value + " 를 삭제하였습니다."
                        + "현재 리스트의 크기는 :" + listLength + " 입니다";
                    deleteNode = null;
                    return temp;
                }

                while (!(count <= 1))
                {
                    count--;
                    deleteNode = deleteNode.next;

                }

                listLength--;
                temp = "List 의 " + index + " 번째에 위치한 " + deleteNode.value + " 를 삭제하였습니다."
                    + "현재 리스트의 크기는 :" + listLength + " 입니다";

                deleteNode.prev.next = deleteNode.next;
                deleteNode.next.prev = deleteNode.prev;
                deleteNode = null;
                return temp;
            }
        }

    }
}
