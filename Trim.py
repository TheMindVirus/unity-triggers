import bpy

def console(level = "OUTPUT", *args):
    for window in bpy.context.window_manager.windows:
        screen = window.screen
        for area in screen.areas:
            if area.type == "CONSOLE":
                override = {"window": window, "screen": screen, "area": area}
                output = ""
                for arg in args:
                    output += str(arg)
                    try:
                        bpy.ops.console.scrollback_append(override, text = str(output), type = level)
                    except:
                        pass

def print(*args):
    console("OUTPUT", *args)
    
def error(*args):
    console("ERROR", *args)

try:
    for obj in bpy.data.objects["Model"].children:
        for i in range(0, len(obj.children)):
            if i != 0:
                bpy.data.objects.remove(obj.children[i], do_unlink = True)
    print("Done!")
except Exception as e:
    error(type(e).__name__, ": ", e)