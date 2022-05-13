import { createApp } from 'vue'

const app = createApp({
    data() {
        return {
            cereals: [],
            filterName: "",
            filterNutriScore: [],
            filterCategory: "tous",
            countCereals: 0,
            averageCalories: 0.0,
        }
    },
    methods: {
        async generateCereals() {
            const apiResponse = await fetch("https://arfp.github.io/tp/web/frontend/cereals/cereals.json")
            const json = await apiResponse.json()
            this.cereals = json.data
            this.cereals.forEach((cereal) => {
                this.addNutriscoreCereal(cereal)
                this.removeUnknownPropertiesCereal(cereal)
            })
        },
        addNutriscoreCereal(cereal) {
            cereal.nutriscore = this.getNutriscore(cereal)
        },
        getNutriscore(cereal) {
            if (cereal.rating > 80) {
                return "A"
            } else if (cereal.rating > 70) {
                return "B"
            } else if (cereal.rating > 55) {
                return "C"
            } else if (cereal.rating > 35) {
                return "D"
            } else {
                return "E"
            }
        },
        removeUnknownPropertiesCereal(cereal) {
            for (const property in cereal) {
                if (cereal[property] === - 1) {
                    cereal[property] = null
                }
            }
        },
        removeCereal(cerealToRemove) {
            this.cereals = this.cereals.filter((cereal) =>
                cereal.id != cerealToRemove.id
            )
        },
        isCerealWithoutSugar(cereal) {
            return cereal.sugars < 1 && cereal.sugars !== null
        },
        isCerealPoorSodium(cereal) {
            return cereal.sodium < 50 && cereal.sodium !== null
        },
        isCerealBoost(cereal) {
            return cereal.vitamins >= 25 
                && cereal.fiber >= 10
                && cereal.vitamins !== null
                && cereal.fiber !== null
        },
        setFilterByName() {
            this.filterName = event.target.value.toLowerCase()
        },
        doFilterByName(listCereals) {
            if (this.filterName.length > 0) {
                return listCereals.filter((cereal) =>
                    cereal.name
                        .toLowerCase()
                        .includes(this.filterName)
                )
            }
            return listCereals
        },
        setFilterByNutriscore() {
            const allCheckedBox = event.target.parentNode
                .querySelectorAll('input[type=checkbox]:checked')
            this.filterNutriScore = []

            if (allCheckedBox.length > 0) {
                allCheckedBox.forEach((checkedBox) => {
                    this.filterNutriScore.push(checkedBox.value.toLowerCase())
                })
            }
        },
        doFilterByNutriscore(listCereals) {
            if (this.filterNutriScore.length > 0) {
                return listCereals.filter((cereal) =>
                    this.filterNutriScore.includes(
                        cereal.nutriscore.toLowerCase()
                    )
                )
            }
            return listCereals
        },
        setFilterByCategory() {
            this.filterCategory = event.target.value.toLowerCase()
            console.log(this.filterCategory)
        },
        doFilterByCategory(listCereals) {
            switch (this.filterCategory) {
                case "sans_sucre":
                    return listCereals.filter((cereal) =>
                        this.isCerealWithoutSugar(cereal)
                    )
                    case "pauvre_sel":
                    return listCereals.filter((cereal) =>
                        this.isCerealPoorSodium(cereal)
                    )
                    case "boost":
                    return listCereals.filter((cereal) =>
                        this.isCerealBoost(cereal)
                    )
                default:
                    return listCereals
            }
        },
        setCountCereals(listCereals) {
            this.countCereals = listCereals.length
        },
        setAverageCalories(listCereals) {
            let sumCerealsColories = 0
            listCereals.forEach((cereal) => 
                sumCerealsColories += cereal.calories
            )
            this.averageCalories = Math.round(
                sumCerealsColories / listCereals.length
            )
        }
    },
    computed: {
        filteredCereals() {
            let cerealsFiltered = this.cereals

            cerealsFiltered = this.doFilterByName(cerealsFiltered)
            cerealsFiltered = this.doFilterByNutriscore(cerealsFiltered)
            cerealsFiltered = this.doFilterByCategory(cerealsFiltered)

            this.setCountCereals(cerealsFiltered)
            this.setAverageCalories(cerealsFiltered)

            return cerealsFiltered
        }
    },
    mounted() {
        try {
            this.generateCereals()
        } catch(err) {
            console.log(err)
        }
    }
})

app.mount('#app')
