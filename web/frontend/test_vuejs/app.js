import { createApp } from 'vue'

const app = createApp({
    data() {
        return {
            name: "toto",
            counter: 0,
            image_url: "",
            image_alt: ""
        }
    },
    methods: {

    }
})

app.mount('#app')
