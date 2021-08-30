Vue.component('carousel-item', {
    //data: function () {
    //    return this.$el.data();
    //},
    props: ['item'],
    template: '<li>{{ item.text }} <img :src=item.img /></li>'
})


Vue.component('accordian-item', {
    props: ['item'],
    template: '<li><h1>{{ item.title }}</h1><p>{{ item.content }}</p></li>'
})

var app = new Vue({
    el: '#app',
    //data: function () {
    //    return this.$el.data('frontend');
    //},
    data: {
        carouselItems: [
            {
                id: 1,
                text: 'test1',
                img: 'https://cdn.pixabay.com/photo/2016/06/29/21/14/women-1487825_960_720.jpg'
            },
            {
                id: 2,
                text: 'test2',
                img: 'https://media.istockphoto.com/photos/portrait-of-two-senior-female-friends-hiking-along-trail-in-together-picture-id1223350504?s=612x612'
            }
        ],
        accordianItems: [
            {
                id: 1,
                title: 'title 1',
                content: 'content 1',
            },
            {
                id: 1,
                title: 'title 2',
                content: 'content 2',
            },
        ]
    }
})



