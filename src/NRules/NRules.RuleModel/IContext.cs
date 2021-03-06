using System;

namespace NRules.RuleModel
{
    /// <summary>
    /// Rules engine execution context.
    /// Can be used by rules to interact with the rules engine, i.e. insert, update, retract facts.
    /// </summary>
    public interface IContext
    {
        /// <summary>
        /// Current rule definition.
        /// </summary>
        IRuleDefinition Rule { get; }

        /// <summary>
        /// Halts rules execution. The engine continues execution of the current rule and exits the execution cycle.
        /// </summary>
        void Halt();

        /// <summary>
        /// Inserts a new fact to the rules engine memory.
        /// </summary>
        /// <param name="fact">Fact to add.</param>
        /// <exception cref="ArgumentException">If fact already exists in working memory.</exception>
        void Insert(object fact);

        /// <summary>
        /// Inserts a fact to the rules engine memory if the fact does not exist.
        /// </summary>
        /// <param name="fact">Fact to add.</param>
        /// <returns>Whether the fact was inserted or not.</returns>
        bool TryInsert(object fact);

        /// <summary>
        /// Updates existing fact in the rules engine memory.
        /// </summary>
        /// <param name="fact">Fact to update.</param>
        /// <exception cref="ArgumentException">If fact does not exist in working memory.</exception>
        void Update(object fact);

        /// <summary>
        /// Updates a fact in the rules engine memory if the fact exists.
        /// </summary>
        /// <param name="fact">Fact to update.</param>
        /// <returns>Whether the fact was updated or not.</returns>
        bool TryUpdate(object fact);

        /// <summary>
        /// Removes existing fact from the rules engine memory.
        /// </summary>
        /// <param name="fact">Fact to remove.</param>
        /// <exception cref="ArgumentException">If fact does not exist in working memory.</exception>
        void Retract(object fact);

        /// <summary>
        /// Removes a fact from the rules engine memory if the fact exists.
        /// </summary>
        /// <param name="fact">Fact to remove.</param>
        /// <returns>Whether the fact was retracted or not.</returns>
        bool TryRetract(object fact);
    }
}