const fs = require('fs/promises');

const test1 = 'dem.txt';

const test2 = 'dem2.txt';

async function example(file) {

  try {

    const data = await fs.readFile(file, { encoding: 'utf8' });

    console.log(data);

  } catch (err) {

    console.log(err);

  }

}

example(test1);

example(test2);