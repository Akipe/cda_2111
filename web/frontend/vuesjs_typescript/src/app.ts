import { createApp, defineComponent } from 'vue'

//var exports = {};

const app = defineComponent({
    props: {
        count: Number,
    },
    data() {
        return {
          count: 0
        }
    }
})

createApp(app).mount('#app')

console.log(`Hello world!`)