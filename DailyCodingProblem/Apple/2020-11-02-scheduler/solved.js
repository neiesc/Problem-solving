scheduler = (f, n) => {
    console.log(`Scheduled the process for ${n} ms`)
    setTimeout(f, n);
};

scheduler(() => { console.log("Done!"); }, 1_000);