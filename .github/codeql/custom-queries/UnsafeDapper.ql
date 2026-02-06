import csharp
import semmle.code.csharp.dataflow.DataFlow

from MethodCall call, Expr source
where
  call.getTarget().getName() = "Query" and
  source = call.getArgument(0) and
  source.toString().matches("%+%")
select call, "Dapper SQL query is built using string concatenation"
