using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and then dequeue
    // Expected Result: The highest priority item should be dequeued first.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        // Enqueue items with different priorities
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3); // Higher priority
        priorityQueue.Enqueue("C", 2);

        // Dequeue the item with the highest priority
        var dequeuedItem = priorityQueue.Dequeue();

        // Assert that "B" (the highest priority) is dequeued
        Assert.AreEqual("B", dequeuedItem);

        // Now dequeue the next highest priority item
        dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("C", dequeuedItem);

        // Finally, dequeue the last item
        dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("A", dequeuedItem);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority and test dequeuing order.
    // Expected Result: The item closest to the front of of the queue should be dequeued first
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
           var priorityQueue = new PriorityQueue();

        // Enqueue multiple items with the same priority
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2); // Same priority
        priorityQueue.Enqueue("C", 2);

        // Dequeue should remove items in the order they were added (FIFO)
        var dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("A", dequeuedItem);

        dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("B", dequeuedItem);

        dequeuedItem = priorityQueue.Dequeue();
        Assert.AreEqual("C", dequeuedItem);
    }

    // Add more test cases as needed below.
}