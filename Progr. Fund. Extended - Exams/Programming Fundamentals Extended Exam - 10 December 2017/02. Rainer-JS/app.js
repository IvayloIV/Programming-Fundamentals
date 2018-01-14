function rainer(arr1, a, b, c, d, e) {
    arr1 = arr1.map(Number);
    let arr2 = new Array();
    arr2.push(Number(a));
    arr2.push(Number(b));
    arr2.push(Number(c));
    arr2.push(Number(d));
    arr2.push(Number(e));

    let lastNum = arr1.pop();

    let steps = 0;
    let currentArr = arr1;
    var indexCount = -1;
    while (true) {
        var donaldIndex = steps == 0 ? lastNum : arr2[indexCount];

        arr1 = arr1.map(a => a - 1);

        if (arr1[donaldIndex] == 0) {
            console.log(arr1.join(' '));
            console.log(steps);
            return;
        }

        arr1 = arr1.map((e, i) => e == 0 ? e = currentArr[i] : e = e);

        indexCount++;
        steps++;
    }
}
rainer(['5', '2', '3', '4', '5', '3'], '0', '1', '4', '1', '1')