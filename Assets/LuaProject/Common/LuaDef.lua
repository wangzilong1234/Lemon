---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by onelei.
--- DateTime: 2020/8/8 23:02
---

LuaDef = {}

LuaDef.BTResult =
{
    NONE = 0,
    SUCCESSFUL = 1,
    FAIL = 2,
    RUNNING = 3,

    ---自定义结果
    ---第一个节点执行成功之后，准备跳到下一个
    NEXT = 4,
}

return LuaDef