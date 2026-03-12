namespace BmSDK.Engine;

public partial class Sequence
{
    /// <summary>
    /// Retrieves all sequence objects of a given type in the current sequence
    /// and optionally its nested sequences as well.
    /// </summary>
    /// <typeparam name="TClass">SequenceObject type to filter for</typeparam>
    /// <param name="isRecursive">Whether to search nested sequences too</param>
    /// <returns>Collection of sequence objects of the specified type in the sequence</returns>
    public IEnumerable<TClass> FindSeqObjectsByClass<TClass>(bool isRecursive)
        where TClass : SequenceObject
    {
        foreach (var seqObj in SequenceObjects.OfType<TClass>())
        {
            yield return seqObj;
        }

        if (!isRecursive || NestedSequences.Count == 0)
        {
            yield break;
        }

        foreach (var subSeq in NestedSequences)
        {
            foreach (var seqObj in subSeq.FindSeqObjectsByClass<TClass>(true))
            {
                yield return seqObj;
            }
        }
    }

    /// <summary>
    /// Retrieves all currently active sequence operations of a given type in
    /// the current sequence and optionally its nested sequences as well.
    /// This is useful when searching for currently active SeqActs.
    /// </summary>
    /// <typeparam name="TClass">SequenceOp type to filter for</typeparam>
    /// <param name="isRecursive">Whether to search nested sequences too</param>
    /// <returns>Collection of sequence ops of the specified type in the sequence</returns>
    public IEnumerable<TClass> FindActiveSeqOpsByClass<TClass>(bool isRecursive)
        where TClass : SequenceOp
    {
        foreach (var seqOp in ActiveSequenceOps.OfType<TClass>())
        {
            yield return seqOp;
        }

        if (!isRecursive || NestedSequences.Count == 0)
        {
            yield break;
        }

        foreach (var subSeq in NestedSequences)
        {
            foreach (var seqOp in subSeq.FindActiveSeqOpsByClass<TClass>(true))
            {
                yield return seqOp;
            }
        }
    }
}
