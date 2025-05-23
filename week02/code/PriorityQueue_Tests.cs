using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items to the queue with Value and Priority value, Value being name. No duplicated priority value is added.
    // Expected Result: Correct sequence of items are being Dequeued each iteration.
    // Defect(s) Found: Initially found that the Length property was set to a Count() method-like call, not a property call for Count.
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 20);
        var tim = new PriorityItem("Tim", 50);
        var sue = new PriorityItem("Sue", 33);
        var san = new PriorityItem("San", 21);
        var jim = new PriorityItem("Jim", 52);
        var jon = new PriorityItem("Jon", 10);
        
        var priorityQueue = new PriorityQueue();
        
        PriorityItem[] expectedResult = [jim, tim, sue, san, bob, jon];
        
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(san.Value, san.Priority);
        priorityQueue.Enqueue(jim.Value, jim.Priority);
        priorityQueue.Enqueue(jon.Value, jon.Priority);

        int i = 0;
        while (priorityQueue.Length > 0){
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Add items to the queue with Value and Priority value, Value being name. Duplicates are added.
    // Expected Result: Items with the same priority values will be dequeued in order of being queued.
    // Defect(s) Found: No defects observed in priority-based ordering.

    public void TestPriorityQueue_2()
    {
        var bob = new PriorityItem("Bob", 20);
        var tim = new PriorityItem("Tim", 50);
        var sue = new PriorityItem("Sue", 33);
        var san = new PriorityItem("San", 20);
        var jim = new PriorityItem("Jim", 50);
        var jon = new PriorityItem("Jon", 10);
        
        var priorityQueue = new PriorityQueue();
        
        PriorityItem[] expectedResult = [tim, jim, sue, bob, san, jon];
        
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(san.Value, san.Priority);
        priorityQueue.Enqueue(jim.Value, jim.Priority);
        priorityQueue.Enqueue(jon.Value, jon.Priority);

        int i = 0;
        while (priorityQueue.Length > 0){
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    // Add more test cases as needed below.
}