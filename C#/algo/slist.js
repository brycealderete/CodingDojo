/* 
1. Mon
  - isEmpty
  - insertAtBack
  - seedFromArr
*/

class Node {
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}

class SList {
  constructor() {
    this.head = null;
  }

  isEmpty() {
    console.log('This is called')
    if(this.head == null) {
      console.log('This list is empty')
      return true;
    }
    else {
      console.log('This list is not empty')
      return false;
    }
  }

  insertAtBack(data) {
    let runner = this.head;

    while (runner.next !== null) {
      runner = runner.next;
    }
    runner.next = new Node(data);
    console.log('Added', data)
    return;
  }

  seedFromArr(arr){
    for(let i = 0; i < arr.length; i++) {
      this.insertAtBack(arr[i]);
    }
    return;
  }

}

const greatGrandpa = new Node("Great Grandpa");
greatGrandpa.next = new Node("Grandpa");
greatGrandpa.next.next = new Node("Dad");
greatGrandpa.next.next.next = new Node("You");
const you = greatGrandpa.next.next.next;

const sList = new SList();
sList.head = greatGrandpa;

sList.isEmpty();

sList.insertAtBack('Child');
