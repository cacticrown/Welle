
function load()
    print("Hello from Welle!")

    texture = welle.graphics.loadTexture("image.png")
    print(texture.path)
end

function update(dt)
    if welle.input.keyboard.isKeyDown("a") then
       print("a is down")
    end
end

function draw()
    welle.graphics.clear(0.5, 0.5, 0.5, 1)

    welle.graphics.beginDraw()
    welle.graphics.draw(texture, 100, 100)
    welle.graphics.endDraw()
end