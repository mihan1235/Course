using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar
{
    public class functionVisitor : functionBaseListener
    {
        /// <summary>
        /// Enter a parse tree produced by <see cref="functionParser.function"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public override void EnterFunction( functionParser.FunctionContext context) {
            Console.WriteLine("EnterFunction: "+context.GetText());
        }
        
    }
}
