﻿using CommandLine;
using Spriggit.CLI;
using Spriggit.CLI.Commands;

return await Parser.Default.ParseArguments(args, typeof(DeserializeCommand), typeof(SerializeCommand))
    .MapResult(
        async (DeserializeCommand deserialize) => await Runner.Run(deserialize),
        async (SerializeCommand serialize) => await Runner.Run(serialize),
        async _ => -1);