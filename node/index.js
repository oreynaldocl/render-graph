const renderGraph = (graph) => {
  let currentQueue = [graph];
  let newQueue = [];
  const resultQueue = [];
  while(currentQueue.length > 0) {
    newQueue = [];

    while (currentQueue.length > 0) {
      const item = currentQueue.shift();
      resultQueue.push(item.text);
      if (item.left) {
        newQueue.push(item.left);
      }
      if (item.right) {
        newQueue.push(item.right);
      }
    }
    currentQueue = newQueue;
  }
  return resultQueue.join(',');
}

const graph = {
  text: 'A',
  left: {
    text: 'B',
    left: {
      text: 'D'
    },
  },
  right: {
    text: 'C',
    left: {
      text: 'E'
    },
    right: {
      text: 'F'
    },
  }
}

console.log(renderGraph(graph));
