public class MedianFinder {
    private PriorityQueue<int, int> large;
    private PriorityQueue<int, int> small;

    public MedianFinder() {
        large = new PriorityQueue<int, int> ();
        small = new PriorityQueue<int, int> ();    
    }
    
    public void AddNum(int num) {
        if (large.Count == 0 || large.Peek() < num)
        {
            large.Enqueue(num, num);
        }
        else
        {
            small.Enqueue(-num, -num);
        }
        if (large.Count - small.Count > 1)
        {
            var item = large.Dequeue();
            small.Enqueue(-item, -item);
        }
        else if (small.Count - large.Count > 1)
        {
            var item = - small.Dequeue();
            large.Enqueue(item, item);
        }
    }
    
    public double FindMedian() {
        if (large.Count == small.Count)
        {
            return (double)(-small.Peek() + large.Peek()) / 2;
        }
        else if (large.Count > small.Count)
        {
            return large.Peek();
        }
        else
        {
            return -small.Peek();
        }
    }
}
